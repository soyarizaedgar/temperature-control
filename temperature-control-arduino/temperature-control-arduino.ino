#include <DHT.h>
#define DHTPIN 7
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

float temperature = 0;
int PIN;
bool analysis_mode = false;

int CONVERT(){
  String number = "";
  int value;
  char digit;
  do{
    digit = Serial.read();
    if(digit>='0' && digit <='9'){
      number += digit;
    }
  }while(digit != '/');
  value = number.toInt();
  return value;
}

void setup() {
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  digitalWrite(2,1);
  digitalWrite(3,1);
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  char character;

  if(analysis_mode == true){
    digitalWrite(3,LOW);
    delay(1000);
    temperature = dht.readTemperature();
    Serial.println(temperature);
  }
  
  if(Serial.available()>0){

    character = Serial.read();

    switch(character){

      case 'E':
      PIN = CONVERT();
      digitalWrite(PIN, LOW);
      break;
      
      case 'A':
      PIN = CONVERT();
      digitalWrite(PIN, HIGH);
      break;
      
      case 'T':
      temperature = dht.readTemperature();
      Serial.println(temperature);
      break;

      default:
      
      break;
    }
   
  }
}
