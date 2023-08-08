from pymongo import MongoClient

client = MongoClient("localhost:27017")

db = client.tya

def retrieve(name):
    try:
        record = db.Emp.find_one({"name": name})
        print("Employee ID: {}\nAge: {}\nCountry: {}".format(record['id'], record['age'], record['country']))
    except Exception as e:
        print(str(e))

name = input("Employee Name: ")

retrieve(name)