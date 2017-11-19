#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "charviewform.h"
#include "libraryform.h"

MainWindow::MainWindow(QWidget *parent) : QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    LoadSubWindow(new CharViewForm(this));
    LoadSubWindow(new LibraryForm(this));
}

MainWindow::~MainWindow()
{
    delete ui;
}
