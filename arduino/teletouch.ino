#include <Servo.h> //Servo kütüphanesi

Servo servo1;
Servo servo2;
Servo servo3;
Servo servo4;
Servo servo5;

int basinc;
String dataSend;
int commacount = 6;
int* numbers = (int*) malloc(commacount * sizeof(int));

char* subStr (char* str, char *delim, int index) {
  char *act, *sub, *ptr;
  static char copy[100];
  int i;
  strcpy(copy, str);
  for (i = 1, act = copy; i <= index; i++, act = NULL) {
     sub = strtok_r(act, delim, &ptr);
     if (sub == NULL) break;
  }
  return sub;
}
  
void setup() {
  
  Serial.begin(9600);
  Serial.setTimeout(10);

  servo1.attach(3);
  servo2.attach(4);
  servo3.attach(5);
  servo4.attach(6);
  servo5.attach(7);
  servo1.write(0);
  servo2.write(0);
  servo3.write(0);
  servo4.write(0);
  servo5.write(0);
  
}

void loop() {
  
  if(Serial.available())
  {
  dataSend = Serial.readString();
  char* buf;
  buf = (char *)malloc(dataSend.length()); //buf = (char *)malloc(dataSend.length());
  dataSend.toCharArray(buf,dataSend.length()+1); 
  
  for(int c = 1; c<commacount; c++){ 
      numbers[c] = atoi(subStr(buf,"/",c)); 
      //Serial.println(numbers[c]); 
  }
  
  Serial.println(numbers[3]);
  
  servo1.write(numbers[1]);
  servo2.write(numbers[2]);
  servo3.write(numbers[3]);
  servo4.write(numbers[4]);
  servo5.write(numbers[5]);
 
  
  free(buf);

  
  }

  }

