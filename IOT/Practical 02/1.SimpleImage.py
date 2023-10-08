# Simple Image Capture

from picamera import PiCamera
from time import sleep

camera = PiCamera()

camera.start_preview()
sleep(5)
camera.capture("/home/pi/Desktop/Images/image.jpg")
camera.stop_preview()