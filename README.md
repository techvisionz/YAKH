# Introduction

YAKH is a .net utility to connect with Kafka server and read messages from given topic. It also provides a feature to filter the messages based on simple and json based filter. It also provides a basic chart to show the number of messages received for given interval.

# Features

## Save multiple Kafka Servers

YAKH internally uses embedded LiteDB to store the configuration related to multiple Kafka servers or topics hierarchically. User does not need to provide all the information every time.

## Easy connect

User can right click on any given topic and connect to server.


## Configuration

Once connected, YAKH will start reading the messages from given topic based on given settings/configuration.

e.g.

**Filter** : Only those messages will be counted/logged which are filtered based on given filter e.g. as json filter &quot;{id:1}&quot; which means incoming messages will be parsed as json and id property will be matched with value &quot;1&quot;.

**Interval** : Interval value is related to chart. Number of messages given in interval will be counted and plotted on the cart accordingly. Value is in milliseconds e.g. as per screenshot it is 5 seconds.

**Logging** : YAKH uses this flag to display received messages in logging text box. Default value is No i.e. no message is displayed in logging text box.

**Store Offset** : YAKH uses this flag to save last offset value. Default value is &quot;No&quot; which means every time user is connected it will start reading from the beginning of the topic.

## Chart

Chart shows the message count accumulated as per interval value.

# Technology Stack

.Net Framework 4.6

Confluent.Kafka

LiteDB

LiveCharts
