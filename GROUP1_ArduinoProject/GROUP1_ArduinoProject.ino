LCSinitialization();
EASinitialization();
GASInitialization();
GSMinitialization();
     
void setup() {
  LCSsetup();
  EASsetup();
  GASsetup();
  delay(100);
  
  Serial.begin(9600); 
void loop() {
  ArduinoGUILoop();
  LCSloop();
  EASloop();
  GASloop();
}


 
   