import RPi.GPIO as GPIO
import time, datetime

GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)

segments = [26, 19, 13, 6, 5, 11, 9, 10]

for segment in segments:
    GPIO.setup(segment, GPIO.OUT)
    GPIO.output(segment, GPIO.LOW)

digits = [7, 8, 25, 24]
for digit in digits:
    GPIO.setup(digit, GPIO.OUT)
    GPIO.output(digit, GPIO.LOW)

null = [1,1,1,1,1,1,1]
zero = [0,0,0,0,0,0,1]
one = [1,0,0,1,1,1,1]
two = [0,0,1,0,0,1,0]
three = [0,0,0,0,1,1,0]
four = [1,0,0,1,1,0,0]
five = [0,1,0,0,1,0,0]
six = [0,1,0,0,0,0,0]
seven = [0,0,0,1,1,1,1]
eight = [0,0,0,0,0,0,0]
nine = [0,0,0,0,1,0,0]

def printSegment(c):
    if c == 1:
        for i in range(7):
            GPIO.output(segments[i], one[i])
    elif c == 2:
        for i in range(7):
            GPIO.output(segments[i], two[i])
    elif c == 3:
        for i in range(7):
            GPIO.output(segments[i], three[i])
    elif c == 4:
        for i in range(7):
            GPIO.output(segments[i], four[i])
    elif c == 5:
        for i in range(7):
            GPIO.output(segments[i], five[i])
    elif c == 6:
        for i in range(7):
            GPIO.output(segments[i], six[i])
    elif c == 7:
        for i in range(7):
            GPIO.output(segments[i], seven[i])
    elif c == 8:
        for i in range(7):
            GPIO.output(segments[i], eight[i])
    elif c == 9:
        for i in range(7):
            GPIO.output(segments[i], nine[i])
    elif c == 0:
        for i in range(7):
            GPIO.output(segments[i], zero[i])
    return

while(True):
    now = datetime.datetime.now()

    hour = now.hour
    minute = now.minute

    h1 = int(hour/10)
    h2 = int(hour % 10)
    m1 = int(minute / 10)
    m2 = int(minute % 10)
    print("{}{}:{}{}".format(h1, h2, m1, m2))
    digitOutputs = [h1, h2, m1, m2]


    delayTime = 0.001

    for i in range(4):
        GPIO.output(digits[i], GPIO.HIGH)
        printSegment(digitOutputs[i])
        time.sleep(delayTime)
        GPIO.output(digits[i], GPIO.LOW)

    # time.sleep(1)