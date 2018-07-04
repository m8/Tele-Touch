# Tele-Touch

**Version 1.0.4**

Robotics offers an efficient way for assistive devices to maintain many errands. In this study it is aimed to present a proof of concept robotic study that is called TeleTouch. TeleTouch is a robotic system that allows mimicking user’s finger motions/gestures to be transferred in a desired remote location with in an acceptable delay. In the implementation Leap motion sensor, Raspberry Pi, and Arduino systems are used. 3D printers printed Hand model is actuated by Arduino system which is responsible for driving the servo motors connected the hand model. Raspberry PI is used not only for transferring camera view of the hand model to the controlling remote system but also it is used for transferring to finger attributes to the Arduino system. A software is developed in .Net platform to gather the user’s attributes of the fingers from leap motion sensor system. Delay times of the local and remote system investigated and understood that proposed system successfully transfer motion in almost real time

## Video

This video gives the general purpose and construction of the project.

[![Video](https://img.youtube.com/vi/tMYQEaX3TbA/hqdefault.jpg)](https://www.youtube.com/watch?v=tMYQEaX3TbA)

## Prerequisites

What things you need to install the system


| Material      | Count  |
| ------------- | -----:|
| Servo Motors       |   5 |
| Raspberry Pi      |   1 |
| Tele-Board V1.3.5 |    1 |
| Arduino Nano          |    1 |
| Wooden Plates      |    1 |
| Power Supply (5V 10A)      |    1 |
| 3D Prints Hand          |  1 |


## Installing

### 3D Printing
First of all we should print all of the parts from 3D printer. In first try we used model from [*bq3D*](https://www.thingiverse.com/thing:906098).

### Installing the Cover

After mounting each servo motor, let's put in the system. You should watch out the aligment of the motors.

## Circuit Designs & Schematics

The current circuit so basic and so easy to control the sytem. We designed a PCB that you can you use in these project. It uses Arduino Nano as a controller. This board can drive 5 servo motor individually. Also it has got humidity(DHT11), temperature(LM35) and light intensity sensors. Also card includes two N-Type transistor that user can use in their applications. Also board has got a Sensorboard connector that user can solder and use.

![](http://www.musaunal.com/wp-content/uploads/2018/06/teleboard-e1529317754115-1024x768.jpg)

- [X] Tested

## Methodology

Project construction is planned in three basic stages. The first stage includes the user interface software. In the second step, the finger and hand values can be accessed via the internet and at the same time the Python code is written in order to transfer the image on the TCP / IP protocol. Finally, the Arduino platform was chosen to read the control and sensor values of the servo motors. First of all, the user attaches Leap Motion to his computer. Then it starts the application, which is prepared in C #. When the user moves his / her hands and fingers; Hand information is read and interpreted by the application. Then the user enters the IP address of the device he wants to connect to and then connects to the opposite device (to server). The connected device is actually a small computer. The preferred card in this project is Raspberry Pi. Alternatively, cards such as BeagleBone may be used. The most important feature of these cards is to have an operating system (Linux) embedded in them. With this operating system it is possible to run complex programs that microcontrollers can not run. In this context, the Python code in Raspberry Pi responds to requests to connect over IP (clients). After the connection, the Arduino card connected to Raspberry Pi reads the sensor values via the serial port and the media information is sent to the interface. These values are plotted in real time on the interface. Hand and finger data from the interface are also sent to Arduino in the same way. These are converted to PWM waves for robot hand control and are provided for hand movement. In addition, the user interface from the camera on the robot hand goes to the camera image and the media data read from the sensor.



## Software Part
To use Leap Motion in the project, the C # programming language is preferred. It is worth pointing out that C # is a big influence of the SDK in preference. Also user interface developed from .Net platform.

![](http://www.musaunal.com/wp-content/uploads/2018/06/P1.png)





You can control the system like
```c++
SET_SERVO(0000000011111111222222223333333344444444555555556666666677777777);
GO();
```
## Some models that can be shown

```
0008800000088000000880008888888888888888000880000008800000088000          => (1/x)^2 + (1/y)^2
0000000000088000008888000888888008888880008888000008800000000000          => Cylinder
0000000000000000008888000088880000888800008888000000000000000000          => Square
8888888886333368863553688630036886300368863333688666666888888888          => (x)^2 + (y)^2
0000888800008888000088880000888888880000888800008888000088880000          => sign(xy)
0000000000033000003553000358853003588530003553000003300000000000          => sqrt(1-x^2-y^2)
0000000003333330035555300358853003588530035335300355553000000000          => pyramid
```



## Built With

* [Arduino](https://www.arduino.cc/) - For Controlling Circuit
* [.Net](https://docs.microsoft.com/en-gb/dotnet/csharp/programming-guide/) - .Net For GUI

## Authors

* **Musa Sadık Unal** - *Initial work* - [musaunal.com](http://www.musaunal.com/)
* **Ersin Erturk** - *Initial work*

## What We Plan To Do

- [ ] Add Leap Motion Interaction
- [ ] Eagle Schematic 
- [ ] Preparing GUI

## Acknowledgments

* Thanks to inFORM team for inspiration  (Especially thanks to Daniel Leithinger)
* First 3D parts from [*DesignCell*](https://www.thingiverse.com/thing:2038205) 

