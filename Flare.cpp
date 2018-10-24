// 아두이노 1602 텍스트LCD 실험
#include <LiquidCrystal.h>

LiquidCrystal lcd(7,8,9,10,11,12);//RS,E,DB4,DB5,DB6,DB7
int flare = 0;
int shot = 0;
int maxShot = 0;

void setup()
{
  lcd.begin(16,2);
  lcd.setCursor(0,0);
  lcd.write("SHOTS : ");
  Serial.begin(9600);
}

void loop()
{ 
  flare = analogRead(A0);
  if(flare < 100){
    shot += 1;
  }
  if(shot < maxShot){
    lcd.setCursor(8,0);
    lcd.print(shot);
  }
  else{
    lcd.setCursor(0,0);
    lcd.write("SHOT FINISHED");
  }
  delay(200);
}