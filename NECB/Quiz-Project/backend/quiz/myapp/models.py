from django.db import models
from django.contrib.auth.models import User

# by default User is in django-admin

class Category(models.Model):
    category = models.CharField(max_length=255)
    category_image = models.CharField(max_length=255)
    details = models.CharField(max_length=255)

    def __str__(self):
        return self.category

class CategoryInfo(models.Model):
    test_name = models.CharField(max_length=255)
    test_no = models.BigIntegerField()
    test_level = models.BigIntegerField()
    test_photo = models.CharField(max_length=255)
    description = models.CharField(max_length=255)
    category = models.ForeignKey(Category, on_delete=models.CASCADE)

    def __str__(self):
        return self.test_name

class Quiz(models.Model):
    question = models.CharField(max_length=255)
    answer = models.CharField(max_length=255)
    category_info = models.ForeignKey(CategoryInfo, on_delete=models.CASCADE)

    def __str__(self):
        return self.question

class QuestionOptions(models.Model):
    option = models.CharField(max_length=255)
    quiz = models.ForeignKey(Quiz, on_delete=models.CASCADE)

    def __str__(self):
        return self.option

class Leaderboard(models.Model):
    rank = models.BigIntegerField()
    username = models.CharField(max_length=255)
    score = models.BigIntegerField()
    category = models.CharField(max_length=255)

    def __str__(self):
        return f"{self.rank} - {self.username}"

class Profile(models.Model):
    username = models.CharField(max_length=255)
    firstname = models.CharField(max_length=255)
    lastname = models.CharField(max_length=255)
    email = models.EmailField(max_length=255)
    age = models.BigIntegerField()
    user = models.ForeignKey(User, on_delete=models.CASCADE)

    def __str__(self):
        return self.username
