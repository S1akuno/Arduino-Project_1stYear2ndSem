void LCDinitialization(){
    #include <LiquidCrystal_I2C.h>
    LiquidCrystal_I2C lcd(0x27,16,2);
}

void LCDsetup(){
  // Turn on the blacklight and print a message.
  lcd.backlight();
}

void LCDmessage(){
  
}