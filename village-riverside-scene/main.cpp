#include<windows.h>

#include<GL/glut.h>

#include<stdio.h>

#include<math.h>

#include<string.h>

#define PI 3.1416


float  tx = 0.0f, bx = 0.0f, cx = 10, dx = 0.0, hx = 0;


GLfloat i = 0.0f;


void Idle()


{


    glutPostRedisplay();


}

void circle(float radius, float x, float y) {

    int i;

    int triangleAmount = 100; //# of triangles used to draw circle

    //GLfloat radius = 0.8f; //radius

    GLfloat twicePi = 2.0f * 3.1415926;

    glBegin(GL_TRIANGLE_FAN);

    glVertex2f(x, y); // center of circle

    for (i = 0; i <= triangleAmount; i++) {

        glVertex2f(

            x + (radius * cos(i * twicePi / triangleAmount)),

            y + (radius * sin(i * twicePi / triangleAmount))

        );

    }

    glEnd();

}


void round(GLfloat rx, GLfloat ry, GLfloat cx, GLfloat cy)

{

    glBegin(GL_POLYGON);

    glVertex2f(cx, cy);

    for (int i = 0; i <= 360; i++)

    {

        float angle = i * 3.1416 / 180;

        float x = rx * cos(angle);

        float y = ry * sin(angle);

        glVertex2f((x + cx), (y + cy));

    }

    glEnd();

}


void display(){


    glClearColor(0.0, 1.0, 1.0, 1.0);


    glClear(GL_COLOR_BUFFER_BIT);


    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(0,0);


    glVertex2f(0,100);


    glVertex2f(100,100);


    glVertex2f(100,0);


    glEnd();

    glColor3f(0.0,255, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(0,0);


    glVertex2f(0,45);


    glVertex2f(100,45);


    glVertex2f(100,0);


    glEnd();

    glColor3f(139,0.0,0.0);


    glBegin(GL_POLYGON);


    glVertex2f(3,42);


    glVertex2f(4,42);


    glVertex2f(4,47);


    glVertex2f(3,47);


    glEnd();

    glColor3f(0.0,0.5, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(1,47);


    glVertex2f(6,47);


    glVertex2f(5,48);


    glVertex2f(2,48);


    glEnd();

    glColor3f(0.0,0.5, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(1,48);


    glVertex2f(6,48);


    glVertex2f(5,49);


    glVertex2f(2,49);


    glEnd();



    // Draw sun

    glColor3f(255,255,255);

    circle(5, 85, 85);

      glEnd();

       glColor3f(255,255,255);

    circle(0.3,4,60);

      glEnd();

       glColor3f(255,255,255);

    circle(0.3,8,65);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,10,56);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,12,74);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,15,78);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,4,90);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,6,90);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,20,70);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,25,56);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,25,70);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,30,65);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,35,90);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,30,87);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,45,90);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,45,67);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,55,65);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,56,95);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,65,90);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,65,77);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,55,67);

      glEnd();


        glColor3f(255,255,255);

    circle(0.3,87,65);

      glEnd();

        glColor3f(255,255,255);

    circle(0.3,90,90);

      glEnd();


    glColor3f(0.0,0.5, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(1,49);


    glVertex2f(6,49);


    glVertex2f(3.5,52);

    glEnd();

    glColor3f(139,0.0,0.0);


    glBegin(GL_POLYGON);


    glVertex2f(9,42);


    glVertex2f(10,42);


    glVertex2f(10,47);


    glVertex2f(9,47);


    glEnd();

     glColor3f(0.0,0.5, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(7,47);


    glVertex2f(12,47);


    glVertex2f(11,48);


    glVertex2f(8,48);


    glEnd();

      glColor3f(0.0,0.5, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(7,48);


    glVertex2f(12,48);


    glVertex2f(11,49);


    glVertex2f(8,49);


    glEnd();

    glColor3f(0.0,0.5, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(7,49);


    glVertex2f(12,49);


    glVertex2f(9.5,52);


    glEnd();

    glColor3f(128,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(20,42);


    glVertex2f(28,42);


    glVertex2f(26.5,55);


    glVertex2f(21.5,55);


    glEnd();

     glColor3f(0.0, 0.0, 0.0);


     circle(2, 24,58);


     glEnd();

      glColor3f(0.0, 0.0, 0.0);


     circle(2, 26,60);


     glEnd();

     glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(27,52);


    glVertex2f(21,52);


    glVertex2f(21,51);


    glVertex2f(27,51);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(27.5,45);


    glVertex2f(20.5,45);


    glVertex2f(20,44);


    glVertex2f(28,44);


    glEnd();

    glColor3f(1.0,0.5,0.0);


    glBegin(GL_POLYGON);


    glVertex2f(40,42);


    glVertex2f(55,42);


    glVertex2f(55,50);


    glVertex2f(40,50);


    glEnd();

    glColor3f(1.0,1.0,0.0);


    glBegin(GL_POLYGON);


    glVertex2f(45,50);


    glVertex2f(45,55);


    glVertex2f(60,55);


    glVertex2f(60,42);


    glVertex2f(55,42);


    glVertex2f(55,50);


    glVertex2f(45,50);


    glEnd();


    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(42,43);


    glVertex2f(43,43);


    glVertex2f(43,46);


    glVertex2f(42,46);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(44,43);


    glVertex2f(45,43);


    glVertex2f(45,46);


    glVertex2f(44,46);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(46,43);


    glVertex2f(47,43);


    glVertex2f(47,46);


    glVertex2f(46,46);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(48,43);


    glVertex2f(49,43);


    glVertex2f(49,46);


    glVertex2f(48,46);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(42,47);


    glVertex2f(43,47);


    glVertex2f(43,49);


    glVertex2f(42,49);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(44,47);


    glVertex2f(45,47);


    glVertex2f(45,49);


    glVertex2f(44,49);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(53,51);


    glVertex2f(58,51);


    glVertex2f(58,53);


    glVertex2f(53,53);


    glEnd();


    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(47,51);


    glVertex2f(52,51);


    glVertex2f(52,53);


    glVertex2f(47,53);


    glEnd();

     glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(48.5,47);


    glVertex2f(53,47);


    glVertex2f(53,49);


    glVertex2f(48.5,49);


    glEnd();

     glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(54,47);


    glVertex2f(58,47);


    glVertex2f(58,49);


    glVertex2f(54,49);


    glEnd();

     glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(54,43);


    glVertex2f(59,43);


    glVertex2f(59,45);


    glVertex2f(54,45);


    glEnd();

     glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(41,50);


    glVertex2f(44,50);


    glVertex2f(43.5,57);


    glVertex2f(41.5,57);


    glEnd();

    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(50,55);


    glVertex2f(55,55);


    glVertex2f(53,65);


    glVertex2f(51.5,65);


    glEnd();

     glColor3f(0.0,0.0,0.0);


     circle(2, 43.5,59);


     glEnd();

     glColor3f(0.0,0.0,0.0);


     circle(2, 45,61);


     glEnd();


      glColor3f(0.0, 0.0, 0.0);


     circle(2, 52,67.5);


     glEnd();


      glColor3f(0.0, 0.0, 0.0);


     circle(2, 54,69);


     glEnd();


    glColor3f(1.0,0.7, 0.4);


    glBegin(GL_POLYGON);


    glVertex2f(70,42);


    glVertex2f(90,42);


    glVertex2f(90,55);


    glVertex2f(70,55);


    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(70,55);


    glVertex2f(90,55);


    glVertex2f(90,56);


    glVertex2f(70,56);


    glEnd();

    glColor3f(1.0,0.7, 0.4);


    glBegin(GL_POLYGON);


    glVertex2f(70,56);


    glVertex2f(90,56);


    glVertex2f(80,65);

    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(76,58);


    glVertex2f(84,58);


    glVertex2f(84,60);


    glVertex2f(76,60);


    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(79,62);


    glVertex2f(81,62);


    glVertex2f(81,56.5);


    glVertex2f(79,56.5);


    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(75,42);


    glVertex2f(85,42);


    glVertex2f(85,51);


    glVertex2f(75,51);


    glEnd();

      glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(76,45);


    glVertex2f(79,45);


    glVertex2f(79,49);


    glVertex2f(76,49);


    glEnd();

      glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(81,45);


    glVertex2f(84,45);


    glVertex2f(84,49);


    glVertex2f(81,49);


    glEnd();




    glColor3f(0.0,0.749,0.647);


    glBegin(GL_POLYGON);


    glVertex2f(0,20);


    glVertex2f(0,40);


    glVertex2f(100,40);


    glVertex2f(100,20);


    glEnd();

      glPushMatrix();

    glTranslatef(bx,0.0,0.0);


    glColor3f(0.0,0.0, 0.0);


    glBegin(GL_POLYGON);


    glVertex2f(35,28);


    glVertex2f(45,28);


    glVertex2f(47,30);


    glVertex2f(34,30);


    glEnd();

    glColor3f(255,255, 255);


    glBegin(GL_POLYGON);


    glVertex2f(40,30);


    glVertex2f(45,32);


    glVertex2f(40,38);

    glEnd();


    glColor3f(255,255, 255);


    glBegin(GL_POLYGON);


    glVertex2f(39.5,30);


    glVertex2f(35,31);


    glVertex2f(39.5,37);

    glEnd();


    glPopMatrix();

    bx += .002;

    if (bx > 100)

        bx = -40;

    glutPostRedisplay();


     glColor3f(1.0,0.7, 0.4);


    glBegin(GL_POLYGON);


    glVertex2f(90.5,42);


    glVertex2f(100,42);


    glVertex2f(100,65);


    glVertex2f(90.5,65);

    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(91.5,43);


    glVertex2f(95,43);


    glVertex2f(95,50);


    glVertex2f(91.5,50);

    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(96,43);


    glVertex2f(100,43);


    glVertex2f(100,50);


    glVertex2f(96,50);

    glEnd();

    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(91.5,51);


    glVertex2f(95,51);


    glVertex2f(95,57);


    glVertex2f(91.5,57);

    glEnd();

     glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(96,51);


    glVertex2f(100,51);


    glVertex2f(100,57);


    glVertex2f(96,57);

    glEnd();


    glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(91.5,58);


    glVertex2f(95,58);


    glVertex2f(95,64);


    glVertex2f(91.5,64);

    glEnd();


     glColor3f(0.647,0.165, 0.165);


    glBegin(GL_POLYGON);


    glVertex2f(96,58);


    glVertex2f(100,58);


    glVertex2f(100,64);


    glVertex2f(96,64);

    glEnd();

  glColor3f(0.545, 0.271, 0.075);


    glBegin(GL_POLYGON);


    glVertex2f(4,15);


    glVertex2f(4,21);


    glVertex2f(5,21);


    glVertex2f(5,15);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(1,18);


    glVertex2f(3,20);


    glVertex2f(2,21);


    glVertex2f(3,22);


    glVertex2f(2,23);


    glVertex2f(4.5,25.5);


    glVertex2f(7,23);


    glVertex2f(6,22);


    glVertex2f(7,21);


    glVertex2f(6,20);


    glVertex2f(8,18);


    glEnd();


///////////////////////////////right tree2/////////////////////////////


    glColor3f(0.545, 0.271, 0.075);


    glBegin(GL_POLYGON);


    glVertex2f(72,19);


    glVertex2f(72,25);


    glVertex2f(73,25);


    glVertex2f(73,19);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(69,23);


    glVertex2f(71,25);


    glVertex2f(70,26);


    glVertex2f(71,27);


    glVertex2f(70,28);


    glVertex2f(72.5,30.5);


    glVertex2f(75,28);


    glVertex2f(74,27);


    glVertex2f(75,26);


    glVertex2f(74,25);


    glVertex2f(76,23);


    glEnd();

    /////////////////////////////////////right tree 3////////////


    glColor3f(0.545, 0.271, 0.075);


    glBegin(GL_POLYGON);


    glVertex2f(81,19);


    glVertex2f(81,25);


    glVertex2f(82,25);


    glVertex2f(82,19);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(78,22);


    glVertex2f(80,24);


    glVertex2f(83,24);


    glVertex2f(85,22);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(80,24);


    glVertex2f(79,25);


    glVertex2f(84,25);


    glVertex2f(83,24);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(79,25);


    glVertex2f(80,26);


    glVertex2f(83,26);


    glVertex2f(84,25);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(80,26);


    glVertex2f(79,27);


    glVertex2f(82.5,29.5);


    glVertex2f(84,27);


    glVertex2f(83,26);


    glEnd();


    ///////////////////////////////////////right tree 4//////////////


    glColor3f(0.545, 0.271, 0.075);


    glBegin(GL_POLYGON);


    glVertex2f(88,16);


    glVertex2f(88,21);


    glVertex2f(89,21);


    glVertex2f(89,16);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(85,18);


    glVertex2f(87,20);


    glVertex2f(90,20);


    glVertex2f(92,18);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(87,20);


    glVertex2f(86,21);


    glVertex2f(91,21);


    glVertex2f(90,20);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(86,21);


    glVertex2f(87,22);


    glVertex2f(90,22);


    glVertex2f(91,21);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_POLYGON);


    glVertex2f(87,22);


    glVertex2f(86,23);


    glVertex2f(91,23);


    glVertex2f(90,22);


    glEnd();

    glColor3f(0.133, 0.545, 0.133);


    glBegin(GL_TRIANGLES);


    glVertex2f(86,23);


    glVertex2f(88.5,25.5);


    glVertex2f(91,23);


    glEnd();


    ////////////////////////////turbine 1/////////////

    glColor3f(0.690, 0.769, 0.871);


    glBegin(GL_POLYGON);


    glVertex2f(14,15);


    glVertex2f(14,25);


    glVertex2f(16,25);


    glVertex2f(16,15);


    glEnd();


    glPushMatrix();


    glTranslatef(15,24,0);


    glRotatef(i,0.0,0.0,0.1);

      glColor3f(0.647, 0.165, 0.165);


    glBegin(GL_TRIANGLES);


    glVertex2f(0, 0);


    glVertex2f(2, 5);


    glVertex2f(4, 3);


    glEnd();

    glBegin(GL_TRIANGLES);


    glVertex2f(0, 0);


    glVertex2f(-5, 3);


    glVertex2f(-3, 5);


    glEnd();

    glBegin(GL_TRIANGLES);


    glVertex2f(0, 0);


    glVertex2f(-2, -4);


    glVertex2f(2, -4);


    glEnd();

    glPopMatrix();

       i += .005f;


       //////////////////////turbine 2////////

     glColor3f(0.690, 0.769, 0.871);


    glBegin(GL_POLYGON);


    glVertex2f(29,25);


    glVertex2f(29,27);


    glVertex2f(31,27);


    glVertex2f(31,25);


    glEnd();

     glPushMatrix();


    glTranslatef(30,26,0);


    glRotatef(i,0.0,0.0,0.1);

    glColor3f(0.647, 0.165, 0.165);


    glBegin(GL_TRIANGLES);


    glVertex2f(0,0);


    glVertex2f(2,4);


    glVertex2f(3,2);


    glEnd();

    glColor3f(0.647, 0.165, 0.165);


    glBegin(GL_TRIANGLES);


    glVertex2f(0,0);


    glVertex2f(-3,2);


    glVertex2f(-2,4);


    glEnd();

    glColor3f(0.647, 0.165, 0.165);


    glBegin(GL_TRIANGLES);


    glVertex2f(0,0);


    glVertex2f(1,-4);


    glVertex2f(-1,-4);


    glEnd();

     glPopMatrix();

       i += .005f;


    ////////////////////house 1///////////////////


    glColor3f(0.976, 0.824, 0.043);


    glBegin(GL_POLYGON);


    glVertex2f(29,14);


    glVertex2f(29,22);


    glVertex2f(38,22);


    glVertex2f(38,15);


    glEnd();

    glColor3f(0.976, 0.824, 0.043);


    glBegin(GL_POLYGON);


    glVertex2f(24,15);


    glVertex2f(24,22);


    glVertex2f(29,22);


    glVertex2f(29,14);


    glEnd();

    glColor3f(0.976, 0.824, 0.043);


    glBegin(GL_TRIANGLES);


    glVertex2f(24,22);


    glVertex2f(27,25);


    glVertex2f(29,22);


    glEnd();

    glColor3f(0.282, 0.235, 0.196);


    glBegin(GL_POLYGON);


    glVertex2f(21,21);


    glVertex2f(25,25);


    glVertex2f(27,25);


    glVertex2f(23,21);


    glEnd();

    glColor3f(0.282, 0.235, 0.196);


    glBegin(GL_POLYGON);


    glVertex2f(27,25);


    glVertex2f(35,25);


    glVertex2f(39,21);


    glVertex2f(30,21);


    glEnd();

    glColor3f(1.0, 1.0, 1.0);


    glBegin(GL_POLYGON);


    glVertex2f(26,18);


    glVertex2f(26,20);


    glVertex2f(28,20);


    glVertex2f(28,18);


    glEnd();

     glColor3f(1.0, 1.0, 1.0);


    glBegin(GL_POLYGON);


    glVertex2f(32,14.2);


    glVertex2f(32,19);


    glVertex2f(35,19);


    glVertex2f(35,14.8);


    glEnd();

    /////////////////////////house 2//////////////////////////////


    glColor3f(0.686, 0.647, 0.094);


    glBegin(GL_POLYGON);


    glVertex2f(38,17);


    glVertex2f(38,22);


    glVertex2f(43,22);


    glVertex2f(43,16);


    glEnd();

    glColor3f(0.686, 0.647, 0.094);


    glBegin(GL_POLYGON);


    glVertex2f(38,22);


    glVertex2f(37,23);


    glVertex2f(40,26);


    glVertex2f(43,23);


    glVertex2f(43,22);


    glEnd();

    glColor3f(0.686, 0.647, 0.094);


    glBegin(GL_POLYGON);


    glVertex2f(43,16);


    glVertex2f(43,23);


    glVertex2f(52,23);


    glVertex2f(52,17);


    glEnd();

    glColor3f(0.282, 0.235, 0.196);


    glBegin(GL_POLYGON);


    glVertex2f(37,23);


    glVertex2f(36,24);


    glVertex2f(39,27);


    glVertex2f(40,26);


    glEnd();

    glColor3f(0.282, 0.235, 0.196);


    glBegin(GL_POLYGON);


    glVertex2f(39,27);


    glVertex2f(50,27);


    glVertex2f(54,23);


    glVertex2f(43,23);


    glEnd();

    glColor3f(1.0,1.0,1.0);


    glBegin(GL_POLYGON);


    glVertex2f(39,19);


    glVertex2f(39,21);


    glVertex2f(41,21);


    glVertex2f(41,19);


    glEnd();

    glColor3f(1.0,1.0,1.0);


    glBegin(GL_POLYGON);


    glVertex2f(46,16.2);


    glVertex2f(46,20);


    glVertex2f(49,20);


    glVertex2f(49,16.5);


    glEnd();



   glColor3f(0.690, 0.769, 0.871);


   glBegin(GL_POLYGON);


   glVertex2f(0,0);


   glVertex2f(100,0);


   glVertex2f(100,12);


   glVertex2f(0,12);


   glEnd();

    glColor3f(0.0, 0.0, 0.0);


   glBegin(GL_POLYGON);


   glVertex2f(0,11);


   glVertex2f(100,11);


   glVertex2f(100,12);


   glVertex2f(0,12);


   glEnd();

    glColor3f(255,255,255);


   glBegin(GL_POLYGON);


   glVertex2f(10,4);


   glVertex2f(20,4);


   glVertex2f(20,5);


   glVertex2f(10,5);


   glEnd();


    glColor3f(255,255,255);


   glBegin(GL_POLYGON);


   glVertex2f(30,4);


   glVertex2f(40,4);


   glVertex2f(40,5);


   glVertex2f(30,5);


   glEnd();


    glColor3f(255,255,255);


   glBegin(GL_POLYGON);


   glVertex2f(50,4);


   glVertex2f(60,4);


   glVertex2f(60,5);


   glVertex2f(50,5);


   glEnd();


    glColor3f(255,255,255);


   glBegin(GL_POLYGON);


   glVertex2f(70,4);


   glVertex2f(80,4);


   glVertex2f(80,5);


   glVertex2f(70,5);


   glEnd();


//car//


   glPushMatrix();

   glTranslatef(tx, 0, 0);

   glColor3f(255,255,0.0);

   glBegin(GL_POLYGON);

   glVertex2f(20,5);

   glVertex2f(30,5);

   glVertex2f(30,7);

   glVertex2f(20,7);

   glEnd();


    glColor3f(255,0.0,0.0);

   glBegin(GL_POLYGON);

   glVertex2f(21,7);

   glVertex2f(29,7);

   glVertex2f(28,10);

   glVertex2f(22,10);

   glEnd();


    glColor3f(0.0,0.0,0.0);

   glBegin(GL_POLYGON);

   glVertex2f(23,8);

   glVertex2f(27,8);

   glVertex2f(27,9);

   glVertex2f(23,9);

   glEnd();

    glColor3f(0.0, 0.0, 0.0);

   circle(1, 22,5);

     glEnd();

      glColor3f(0.0, 0.0, 0.0);

   circle(1, 28,5);

     glEnd();

     glPopMatrix();

    tx += .002;

    if (tx > 100)

        tx = -40;

    glutPostRedisplay();


   glFlush();


}


void init() {


    glClearColor(0.0, 1.0, 1.0, 1.0);


    glMatrixMode(GL_PROJECTION);


    glLoadIdentity();


    gluOrtho2D(0.0, 100.0, 0.0, 100.0);


}

int main(int argc, char** argv) {


    glutInit(&argc, argv);


    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);


    glutInitWindowSize(1000, 700);


    glutCreateWindow("scene");


    init();


    glutDisplayFunc(display);

    glutIdleFunc(Idle);


    glutMainLoop();


    return 0;


}


