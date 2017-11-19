#-------------------------------------------------
#
# Project created by QtCreator 2017-11-18T02:12:51
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = CharacterStudio
TEMPLATE = app


SOURCES += src\main.cpp\
        src\mainwindow.cpp \
    src\charviewform.cpp \
    src\libraryform.cpp

HEADERS  += src\mainwindow.h \
    src\charviewform.h \
    src\libraryform.h

FORMS    += src\mainwindow.ui \
    src\charviewform.ui \
    src\libraryform.ui

QMAKE_CXXFLAGS += -std=gnu++14
