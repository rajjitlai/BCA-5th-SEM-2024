from django.contrib import admin

# Register your models here.
from .models import *

admin.site.register(Profile)
admin.site.register(Category)
admin.site.register(CategoryInfo)
admin.site.register(Quiz)
admin.site.register(QuestionOptions)
admin.site.register(Leaderboard)