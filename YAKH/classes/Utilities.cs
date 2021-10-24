using Newtonsoft.Json.Linq;
using System;

namespace YAKH.classes
{
    public class Utilities
    {
        private delegate void MethodInvoker_Logging(ref MainForm _mainForm, string dt, bool clear);

        private delegate void MethodInvoker_Clear(ref MainForm _mainForm);

        public static void UpdateLogViewer(ref MainForm _mainForm, string value, bool clear = false)
        {
            if (_mainForm.InvokeRequired)
            {
                _mainForm.Invoke(new MethodInvoker_Logging(UpdateLogViewer_Real), new object[] { _mainForm, value, clear });
            }
            else
            {
                UpdateLogViewer_Real(ref _mainForm, value, clear);
            }
        }

        private static void UpdateLogViewer_Real(ref MainForm _mainForm, string value, bool clear)
        {
            if (clear)
            {
                _mainForm.uiLog.Text = value + "\r\n";
            }
            else
            {
                _mainForm.uiLog.Text += value + "\r\n";
            }

            _mainForm.uiLog.SelectionStart = _mainForm.uiLog.Text.Length;
            _mainForm.uiLog.ScrollToCaret();
        }
        public static void Clear(ref MainForm _mainForm)
        {
            if (_mainForm.InvokeRequired)
            {
                _mainForm.Invoke(new MethodInvoker_Clear(Clear_Real), new object[] { _mainForm });
            }
            else
            {
                Clear_Real(ref _mainForm);
            }
        }

        private static void Clear_Real(ref MainForm _mainForm)
        {
            _mainForm.uiLog.Clear();
            _mainForm.uiLog.Text = "";
            _mainForm.uiLog.SelectionStart = _mainForm.uiLog.Text.Length;
            _mainForm.uiLog.ScrollToCaret();
        }

        private static int matchJson(JObject filterObj, JObject messageObj)
        {
            int matching = 1;

            if (messageObj == null)
            {
                return 2;
            }

            var filterProps = filterObj.Properties();
            foreach (var fProp in filterProps)
            {
                string filterKey = fProp.Name.ToString();
                string filterValue = fProp.Value.ToString();
                if (messageObj[filterKey] != null && messageObj[filterKey].Type is JTokenType.Object)
                {
                    matching = matchJson(filterObj, (JObject)messageObj[filterKey]);
                }
                else if (fProp.Value.Type is JTokenType.Object)
                {
                    matching = matchJson(((JObject)fProp.Value), messageObj);
                }
                else
                {
                    if (messageObj == null || messageObj[filterKey] == null || !messageObj[filterKey].ToString().Equals(filterValue))
                    {
                        matching = 0;
                        break;
                    }
                }
            }

            return matching;
        }

        public static bool filterMe(string message, string filter, bool isJson, JObject filterObj = null)
        {
            JObject messageObj = null;

            bool matching = true;

            if (isJson)
            {
                try
                {
                    messageObj = JObject.Parse(message);
                }
                catch (Exception e)
                {
                }

                if (messageObj != null)
                {
                    matching = matchJson(filterObj, messageObj) == 0 ? false : true;
                }
                else
                {
                    matching = false;
                }
            }
            else
            {
                matching = message.Contains(filter);
            }

            return matching;
        }
    }
}
