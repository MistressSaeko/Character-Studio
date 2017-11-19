#include "charviewform.h"
#include "ui_charviewform.h"

CharViewForm::CharViewForm(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::CharViewForm)
{
    ui->setupUi(this);
}

CharViewForm::~CharViewForm()
{
    delete ui;
}
