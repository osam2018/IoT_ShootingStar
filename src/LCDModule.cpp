// 아두이노 1602 텍스트LCD 실험
#include <LiquidCrystal.h>
#include <SoftwareSerial.h>

LiquidCrystal lcd(7,8,9,10,11,12);//RS,E,DB4,DB5,DB6,DB7
//Shot count
int flare = 0;
int shot = 0;
int maxShot = 0;
//Sonic sensor
int echoPin = 4;
int trigPin = 3;
//Bluetooth
int blueTx = 1;
int blueRx = 2;
SoftwareSerial bluetoothSerial(blueTx, blueRx);


void setup()
{
  //LCD initialize
  lcd.begin(16,2);
  lcd.setCursor(0,0);
  lcd.write("SHOTS: ");
  lcd.setCursor(0,1);
  lcd.print("DISTANCE: ");
  //Sonic sensor initialize
  pinMode(13, OUTPUT);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  //Set max shot
  maxShot = 20;
  Serial.begin(9600);
}

void loop()
{ 
  
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(5);
  digitalWrite(trigPin, LOW);
  delayMicroseconds(5);
  int distance = pulseIn(echoPin, HIGH) * 340 / 2 / 10000;
  Serial.print("Left distance: ");
  Serial.println(distance);
  lcd.setCursor(10,1);
  lcd.print("            ");
  lcd.setCursor(10,1);
  lcd.print(distance);
  lcd.setCursor(14,1);
  lcd.print("cm");
  
  flare = analogRead(A0);
  if(flare < 100 && shot <21){
    shot += 1;  
  }
  if(shot < maxShot){
    lcd.setCursor(7,0);
    lcd.print(shot);
  }
  if(shot == 20){
    lcd.setCursor(0,0);
    lcd.write("SHOT FINISHED");
    digitalWrite(13, HIGH);
	bluetoothSerial.write("FINISH");
  }
  
  delay(200);
}