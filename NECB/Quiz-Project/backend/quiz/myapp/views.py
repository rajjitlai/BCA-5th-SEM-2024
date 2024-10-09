# from django.http import HttpResponse
from rest_framework.decorators import api_view
from rest_framework.response import Response

@api_view(['GET'])

def testreq(request):
    data = {
        'user1': {
            'name': 'John',
            'age': 25,
            'address': '123 Main St'
        },
        'user2': {
            'name': 'Alice',
            'age': 30,
            'address': '456 Elm St'
        }
    }
    # return HttpResponse("resData")
    return Response(data)