# Random LED Pattern.

import RPi.GPIO as GPIO
from time import sleep
from random import randrange

pins = [29, 31, 33, 35]
GPIO.setmode(GPIO.BOARD)

for pin in pins:
    GPIO.setup(pin, GPIO.OUT)

try:
    while(True):
        randomNum = randrange(1,16)
        binaryNum = format(randomNum, '04b')
        for i in range(4):
            if(int(binaryNum[i])):
                GPIO.output(pins[i], GPIO.HIGH)
            else:
                GPIO.output(pins[i], GPIO.LOW)
        sleep(2)

except KeyboardInterrupt:
    for pin in pins:
        GPIO.output(pin, GPIO.LOW)
    GPIO.cleanup()