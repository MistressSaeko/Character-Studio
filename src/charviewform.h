#ifndef CHARVIEWFORM_H
#define CHARVIEWFORM_H

#include <QWidget>

namespace Ui {
class CharViewForm;
}

class CharViewForm : public QWidget
{
    Q_OBJECT

public:
    explicit CharViewForm(QWidget *parent = 0);
    ~CharViewForm();

protected:
    void InitGL();
    void PaintGL();
    void ResizeGL(int width, int height);

    void mousePressEvent(QMouseEvent *event);
    void mouseMoveEvent(QMouseEvent *event);

private:
    Ui::CharViewForm *ui;
    void DrawScene();
    int xRot;
    int yRot;
    int zRot;

signals:
    void xRotationChanged(int angle);
    void yRotationChanged(int angle);
    void zRotationChanged(int angle);
};

#endif // CHARVIEWFORM_H
