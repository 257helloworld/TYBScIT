from pymongo import MongoClient

client = MongoClient("localhost:27017")

db = client.tya

def delete(name):
    try:
        record = db.Emp.find_one({"name": name})
        print("Employee ID: {}\nAge: {}\nCountry: {}".format(record['id'], record['age'], record['country']))
        
        c = input("\nDelete? [y/n]: ")
        if((c[0]).lower() == 'y'):
            db.Emp.delete_one({"name": name})
            print("\nRecord deleted successfully.")
        else:
            print("Cancelled.")
    except Exception as e:
        print(str(e))

name = input("Employee Name: ")

delete(name)