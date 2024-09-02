# Topic: Quiz System

    This is the project made in NECB Class of NIELIT Imphal, 2024

## Development Stack Used

    1.
    2. 
    3. 

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
    
    Give a password and press enter
    Then register the sites in the admin.py

## Contributors

    - Rajjit Laishram
    - Sanamatum Maibam
    - Aris Hodam
    - Irom Jamesbond 
    - Nathan Keishing
    - Kelvin Laishram
