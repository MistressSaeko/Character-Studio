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

private:
    Ui::CharViewForm *ui;
};

#endif // CHARVIEWFORM_H
