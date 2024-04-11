///////////////////////  INITIALIZATION OF LIGHTING CONTROL SYSTEM  /////////////////////////////
  // Assigning Digital Input PIN numbers
  #define LCS_turnONButton 2
  #define LCS_turnOFFButton 3
  #define LCS_whiteButton 4
  #define LCS_yellowButton 5
  #define LCS_blueButton 6
  #define LCS_redButton 7
  #define LCS_ledWhite 8
  #define LCS_ledYellow 9
  #define LCS_ledBlue 10
  #define LCS_ledRed 11

  // This will indicate when the LED is turned ON or OFF  -   FALSE means OFF
  boolean LCS_blue = false, LCS_red = false, LCS_yellow = false, LCS_white = false;

   // This will indicate if the red button or blue button is pressed
  boolean EQAS_redIndicator = false, EQAS_blueIndicator = false;

  ///////////////////////  INITIALIZATION OF EARTHQUAKE ALARM SYSTEM   ////////////////////////////
   // Assigning Digital Input PIN numbers
  #define EQAS_buzzer1 22
  #define EQAS_ledBlue 24
  #define EQAS_blueButton 26
  #define EQAS_ledRed 28
  #define EQAS_redButton 30
  #define EQAS_buzzer2 32



  #include <SoftwareSerial.h>
  SoftwareSerial myGSM(18,19); // tx, rx pin
  String numbers[] = {"+639351539638"}; // List of recipient numbers  //Sir Joel's number: +639772036585     //,"+639686827682","+639933607232","+639087521252","+639098391709"
  //"+639926908900",
  
///////////////////////  INITIALIZATION OF GATE ACCESS SYSTEM   /////////////////////////////////

  #include <Servo.h>
  Servo servoMain;


  int trigpin = 12; //Location of the pin
  int echopin = 13; //Location of the pin
  int distance;
  float duration;
  float cm;
  boolean gate = false; //used in detection for GUI
  boolean gateMessage = false;
  bool gateOpen = false; // Flag to keep track of gate status
   
    #include <LiquidCrystal_I2C.h>
    LiquidCrystal_I2C lcd(0x27,16,2);
     
void setup() {
  LCSsetup();
  EASsetup();
  GASsetup();
  delay(100);
  LCDsetup();

  myGSM.begin(9600);
  Serial.begin(9600); 
}
void loop() {
  ArduinoGUIloop();
  LCSloop();
  EASloop();
  GASloop();
}


 
   