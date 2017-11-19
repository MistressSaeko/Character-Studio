#include "charviewform.h"
#include "ui_charviewform.h"

#include <QtOpenGL/QtOpenGL>
#include <QtWidgets>

CharViewForm::CharViewForm(QWidget *parent) :
    QGLWidget(QGLFormat(QGL::SampleBuffers), parent),
    ui(new Ui::CharViewForm)
{
    ui->setupUi(this);
}

CharViewForm::~CharViewForm()
{
    delete ui;
}

static void qNormalizeAngle(int &angle)
{
    while (angle < 0)
        angle += 360 * 16;
    while (angle > 360)
        angle -= 360 * 16;
}

CharViewForm::InitGL()
{
    qglClearColor(Qt::black);

    glEnable(GL_DEPTH_TEST);
    glEnable(GL_CULL_FACE);
    glShadeModel(GL_TEXTURE);
    glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);

    static GLfloat lightPosition[4] = { 0, 0, 10, 1.0 };
    glLightfv(GL_LIGHT0, GL_POSITION, lightPosition);
}

CharViewForm::ResizeGL(int width, int height)
{
    int side = qMin(width, height);
        glViewport((width - side) / 2, (height - side) / 2, side, side);

        glMatrixMode(GL_PROJECTION);
        glLoadIdentity();
    #ifdef QT_OPENGL_4_3
        glOrthof(-2, +2, -2, +2, 1.0, 15.0);
    #else
        glOrtho(-2, +2, -2, +2, 1.0, 15.0);
    #endif
        glMatrixMode(GL_MODELVIEW);
}

void CharViewForm::mousePressEvent(QMouseEvent *event)
{
    LastPos = event->pos();
}

void CharViewForm::mouseMoveEvent(QMouseEvent *event)
{
    int dx = event->x() - lastPos.x();
        int dy = event->y() - lastPos.y();

        if (event->buttons() & Qt::LeftButton)
        {
            setXRotation(xRot + 8 * dy);
            setYRotation(yRot + 8 * dx);
        }
        else if (event->buttons() & Qt::RightButton)
        {
            setXRotation(xRot + 8 * dy);
            setZRotation(zRot + 8 * dx);
        }

     LastPos = event->pos();
}

CharViewForm::PaintGL()
{
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glLoadIdentity();
    glTranslatef(0.0, 0.0, -10.0);
    glRotatef(xRot / 16.0, 1.0, 0.0, 0.0);
    glRotatef(yRot / 16.0, 0.0, 1.0, 0.0);
    glRotatef(zRot / 16.0, 0.0, 0.0, 1.0);
    DrawScene();
}

void CharViewForm::DrawScene()
{
    qglColor(Qt::red);

    glBegin(GL_QUADS);
        glNormal3f(0,0,-1);
        glVertex3f(-1,-1,0);
        glVertex3f(-1,1,0);
        glVertex3f(1,1,0);
        glVertex3f(1,-1,0);
    glEnd();

    glBegin(GL_TRIANGLES);
        glNormal3f(0,-1,0.707);
        glVertex3f(-1,-1,0);
        glVertex3f(1,-1,0);
        glVertex3f(0,0,1.2);
    glEnd();

    glBegin(GL_TRIANGLES);
        glNormal3f(1,0, 0.707);
        glVertex3f(1,-1,0);
        glVertex3f(1,1,0);
        glVertex3f(0,0,1.2);
    glEnd();

    glBegin(GL_TRIANGLES);
        glNormal3f(0,1,0.707);
        glVertex3f(1,1,0);
        glVertex3f(-1,1,0);
        glVertex3f(0,0,1.2);
    glEnd();

    glBegin(GL_TRIANGLES);
        glNormal3f(-1,0,0.707);
        glVertex3f(-1,1,0);
        glVertex3f(-1,-1,0);
        glVertex3f(0,0,1.2);
    glEnd();
}
