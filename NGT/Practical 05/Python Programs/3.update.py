from pymongo import MongoClient

client = MongoClient("localhost:27017")

db = client.tya

def update(name):
    try:
        record = db.Emp.find_one({"name": name})
        print("Employee ID: {}\nAge: {}\nCountry: {}".format(record['id'], record['age'], record['country']))
        
        print("\nEnter details to update: ")
        id = input("Employee ID: ")
        age = input("Age: ")
        country = input("Country: ")

        db.Emp.update_one({"name": name}, {"$set": {"id": id, "age": age, "country": country}})

        print("Record updated successfully.")
    except Exception as e:
        print(str(e))

name = input("Employee Name: ")

update(name)