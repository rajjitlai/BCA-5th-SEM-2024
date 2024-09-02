# Topic: Quiz System

    This is the project made in NECB Class of NIELIT Imphal, 2024

## Development Stack Used

    1. Python
    2. djangorestframework
    3. sqlite

## Initial steps to be performed

    - Install python and run the following commands
    - mkdir project_name
    - cd project_name
    - python -m venv env
    - env\Scripts\activate
    - pip install djangorestframework
    - django-admin startproject project_name
    - cd project_name
    - django-admin startapp project

## Debug

    If you face any issue running the scripts saying that running scripts is disabled, run the following command by opening the terminal as administrator
    > Set-ExecutionPolicy unrestricted

## Starting the server

    - Change directory inside project_name\project_name and do the following
    - python manage.py runserver

## Starting DB settings

After we have finished making our database designs and created the models, we can migrate them

    - python manage.py makemigrations
    - python manage.py migrate
    - python manage.py createsuperuser --username admin

    Register the app in project_name\settings.py by adding this
    - INSTALLED_APPS = [
        'myApp'
    ]
    
    Give a password and press enter
    Then register the sites in the project_app\admin.py, and an example code is given below
        from django.contrib import admin
        from .models import *
        admin.site.register(Profile)
        admin.site.register(Category)
        admin.site.register(CategoryInfo)
        admin.site.register(Quiz)
        admin.site.register(QuestionOptions)
        admin.site.register(Leaderboard)

    These are the models that have been created in the models.py

## Contributors

    - Rajjit Laishram
    - Sanamatum Maibam
    - Aris Hodam
    - Irom Jamesbond 
    - Nathan Keishing
    - Kelvin Laishram
