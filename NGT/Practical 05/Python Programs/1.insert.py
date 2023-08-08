from pymongo import MongoClient

client = MongoClient("localhost:27017")

db = client.tya

def insert(id, name, age, country):
    record = {
            "id": id,
            "name": name,
            "age": age,
            "country": country
        }
    print("Inserting record ...")
    try:
        db.Emp.insert_one(record)
        print("Record inserted successfully.")
    except Exception as e:
        print(str(e))

id = input("Employee ID: ")
name = input("Employee Name: ")
age = input("Employee Age: ")
country = input("Employee Country: ")

insert(id, name, age, country)