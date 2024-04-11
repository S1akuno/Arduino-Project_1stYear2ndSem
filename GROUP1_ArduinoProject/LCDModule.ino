void LCDinitialization(){

}

void LCDsetup(){
  // Turn on the blacklight and print a message.
  lcd.backlight();
  lcd.setCursor(0,0);
  lcd.print("  Gate Closed!");
}

void LCDmessage(){
  
}