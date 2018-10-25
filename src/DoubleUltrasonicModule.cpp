#include "Arduino.h"

#define TRIGPIN_1 2
#define ECHOPIN_1 3
#define TRIGPIN_2 4
#define ECHOPIN_2 5
#define LEDPIN_LEFT 7
#define LEDPIN_RIGHT 8

long distanceBoundary = 2;  // Ultrasonic sensor sensitivity
long errorDistance = 1400;  // Ignore boundary

void setup() {
  Serial.begin(9600);
  pinMode(TRIGPIN_1, OUTPUT);
  pinMode(ECHOPIN_1, INPUT);
  pinMode(TRIGPIN_2, OUTPUT);
  pinMode(ECHOPIN_2, INPUT);
  pinMode(LEDPIN_LEFT, OUTPUT);
  pinMode(LEDPIN_RIGHT, OUTPUT);
}

void loop() {

  digitalWrite(TRIGPIN_1, HIGH);
  delayMicroseconds(5);
  digitalWrite(TRIGPIN_1, LOW);
  delayMicroseconds(5);
  int leftDistance = pulseIn(ECHOPIN_1, HIGH) * 340 / 2 / 10000;

  digitalWrite(TRIGPIN_2, HIGH);
  delayMicroseconds(5);
  digitalWrite(TRIGPIN_2, LOW);
  delayMicroseconds(5);
  int rightDistance = pulseIn(ECHOPIN_2, HIGH) * 340 / 2 / 10000;
  
  Serial.print("Left distance : ");
  Serial.print(leftDistance);
  Serial.print(", Right distance : ");
  Serial.println(rightDistance);
  

  if (rightDistance > errorDistance || leftDistance > errorDistance) {
    return;
  }
  if (rightDistance - leftDistance > distanceBoundary) {
    digitalWrite(LEDPIN_LEFT, LOW);
    digitalWrite(LEDPIN_RIGHT, HIGH);
  } else if (leftDistance - rightDistance > distanceBoundary) {
    digitalWrite(LEDPIN_LEFT, HIGH);
    digitalWrite(LEDPIN_RIGHT, LOW);
  } else {
    digitalWrite(LEDPIN_LEFT, LOW);
    digitalWrite(LEDPIN_RIGHT, LOW);
  }
  
  delay(500);
}
