import socket
#import serial
import cv2
import numpy as np
import sys
import pickle
import struct
import binascii


#arduino = serial.Serial('COM5',115200,timeout= .1)

cap=cv2.VideoCapture(0)
#cap.set(cv2.CAP_PROP_FPS,10)
#cap.set(cv2.CAP_PROP_FRAME_HEIGHT,240)
#cap.set(cv2.CAP_PROP_FRAME_WIDTH,320)

TCP_IP = '0.0.0.0'
TCP_PORT = 8001
BUFFER_SIZE = 1024

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((TCP_IP, TCP_PORT))
s.listen(1)

conn, addr = s.accept()

print 'Baglanan adres:', addr

while 1:

    #receive

    data = conn.recv(BUFFER_SIZE)
    try:
         if (data == None):
             break

         b = bytearray()
         b.extend(map(ord, data))
         das = str(b.decode("utf-16"))
         asd = das.split('/')
         if (len(asd) != 6):
             continue
         print das
         #arduino.write(das)

         #Send
         s = [1,1,1,1]



         ret, frame = cap.read()
         cv2.imshow('window-name', frame)
         imgdata = frame.data

         sensor = bytearray(s)

         imageData = bytearray(struct.pack("L", len(imgdata))) + imgdata
         sensorData = struct.pack("L", len(sensor)) + sensor
         conn.send(imageData + sensorData)  ### new code



    except ValueError:

        print 'err ', ValueError

conn.close()