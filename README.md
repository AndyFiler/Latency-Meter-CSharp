
# QuizizzSupport
[![GitHub top language](https://img.shields.io/github/languages/top/AndyFilter/Latency-Meter-CSharp)](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))  [![Windows](https://img.shields.io/badge/platform-Windows-0078d7.svg?)](https://en.wikipedia.org/wiki/Microsoft_Windows) ![GitHub all releases](https://img.shields.io/github/downloads/AndyFilter/Latency-Meter-CSharp/total) [![GitHub](https://img.shields.io/github/license/AndyFilter/Latency-Meter-CSharp)](https://github.com/AndyFilter/Latency-Meter-CSharp/blob/main/LICENSE) 



This program lets you **measure latency of your system** given that you have Arduino. ***Now in C#!***

# Measure performance and latency of your PC
Are you Interested in measuring the latency of your system, but can't afford **750$ monitor**? Well in that case you are not alone! This program let's you even measure the latency of single component like **mouse latency, system latency,** or just overall latency.


# What will you need

 - **Arduino** (I used UNO, but I think it will work with other too)
 - Some jumper wires.
 - A photoresistor.
 - Like a 500Ω resistor (Not required. I think you can use built-in pullup resistor).
 - A button.
 - Windows 10 and basic knowledge of using it.
# How to install

 1. Make sure you are in a possession of **Arduino**.
 2. Connect the Arduino to the other elements as follows:

> **Light_Sensor - A0,**  
**Button - 2**

I would recommend putting a **500Ω resistor in series with the light sensor**. The button is configured to use a arduino UNO built-in **"pullup resistor" (button, INPUT_PULLUP)**.

**Remainder!** button is reversed, I mean the code detects press of a button normally, but the state is different (if(buttonState == LOW)). All it means is that you plug it to Digital Pin 2 and Ground.

**For the ease of use** I would suggest connecting **photoresistor not on the same board as the button**, even better just don't use a board for it! Because you will need to place it in the correct place of your monitor.

![Arduino UNO Schema](https://raw.githubusercontent.com/AndyFilter/Latency-Meter-CSharp/main/Media/LightsensorLatencyMeter.png)
 3. Connect the Arduino to the PC via USB.
 4. Upload the [***Code***](https://github.com/AndyFilter/Latency-Meter-CSharp/blob/main/Arduino/SystemLatencyMeter/SystemLatencyMeter.ino) onto the board.
 5. Download the [***latest release***](https://github.com/AndyFilter/Latency-Meter-CSharp/releases/latest) of the program.

# How to use

 1. Connect the Arduino the the PC via USB.
 2. Open the program and set the correct **serial port of the Arduino**.
 3. Press *Start*. If everything goes right program should not close and you should see no errors.
 4. Move the photoresistor so that it *looks* at the black rectangle of the program.
 5. Press the **Button** connected to the **PIN 2** of the Arduino.
 6. The measurements should appear on the screen!
 7. You can now **Save** them, **Export** them and if that's not your first time using the program you can even **Import** the Saves you Exported earlier!

# Questions and Issues
If you have any kind of question or issue to report. DM me through Discord: **IsPossible#8212**, or on **GitHub**


# Edits & Forks
Feel free to fork the project. Tweak, fix and add to the code. I tried to add as many **useful comments** to the code as it's possible, so code should be **easy to read**.
I'll be fixing and adding to the code myself, when I'll see a need to.

**I'll be writing most of the code for the program from the ground up**, because it was not clean and transparent enough.

# Support me!
Buy me a coffee if you think I earned it! **Any amount means a lot** for me, please **consider donating** if you can.

[![PayPal](https://img.shields.io/badge/donate-PayPal-orange.svg?style=logo=PayPal)](https://www.paypal.me/MaciejGrzeda)
<!--stackedit_data:
eyJoaXN0b3J5IjpbLTIwNDQ2OTgxODVdfQ==
-->
