//Event Driven Program

#include <windows.h>  // for MS Windows
#include <GL/glut.h>  // GLUT, include glu.h and gl.h

/* Handler for window-repaint event. Call back when the window first appears and
whenever the window needs to be re-painted. */

void display() {
	glClearColor(1.0f, 1.0f, 1.0f, 0.0f); // Set background color to black and opaque
	glClear(GL_COLOR_BUFFER_BIT);         // Clear the color buffer (background)

        glPointSize(5.0);
        //drawing points
        glBegin(GL_POINTS);
            glColor3f(1.0f, 0.0f, 0.0f); //Red
            glVertex2f(0.5, 0.5);

            glColor3f(0.0f, 1.0f, 0.0f); //Green
            glVertex2f(-0.5, -0.5);
        glEnd();

        glBegin(GL_LINES);
            //X-Axis
            glColor3f(0.0f, 1.0f, 0.0f); //Green
            glVertex2f(-1.0f, 0.0f);
            glVertex2f(1.0f, 0.0f);

            //Y-Axis
            glColor3f(0.0f, 0.0f, 1.0f); //Green
            glVertex2f(0.0f, 1.0f);
            glVertex2f(0.0f, -1.0f);
        glEnd();

        glBegin(GL_TRIANGLES);
            //Blue Triangle
            glColor3f(0.0f, 0.0f, 1.0f);
            glVertex2f(-0.3f, 0.3f);
            glVertex2f(-0.8f,0.3f);
            glVertex2f(-0.8f, 0.8f);
        glEnd();

        glBegin(GL_POLYGON);
            glColor3f(1.0f, 0.0f, 0.0f);
            glVertex2f(0.4f,-0.4f);
            glVertex2f(0.8f,-0.4f);
            glVertex2f(0.8f,-0.8f);
            glVertex2f(0.4f,-0.8f);
        glEnd();

	glFlush();  // Render now
}

/* Main function: GLUT runs as a console application starting at main()  */
int main(int argc, char** argv) {

	//Initialize openGL states
	glutInit(&argc, argv);                 // Initialize GLUT
	glutCreateWindow("Lab 1 Section: E"); // Create a window with the given title
	glutInitWindowSize(320, 320);   // Set the window's initial width & height
	//init();

	//Registering Callback function
	glutDisplayFunc(display); // Register display callback handler for window re-paint

	//Event processing loop
	glutMainLoop();           // Enter the event-processing loop
	return 0;
}


