# 🐈 Contoso Pets Application

Contoso Pets Application is a simple C# console program that allows users to manage a list of pets. Users can add, list, edit, and delete pets. The application is built for learning and basic CRUD (Create, Read, Update, Delete) operations demonstration.

## 📋 Features

- Add a new pet
- List all pets
- Edit a pet's information
- Delete a pet
- Exit

## ⚙ Technologies Used

- C# (.NET Core Console Application)
- Object-Oriented Programming (Classes and Properties)
- LINQ (FirstOrDefault, RemoveAll)
- Basic input validation (int.TryParse, string checks)

## 🚀 How to Use

1. Clone or download the project.
2. Open the project in your favorite C# IDE (e.g., Visual Studio).
3. Build and run the program.

## Usage

The project uses basic C# concepts like `List<T>`, `FirstOrDefault()`, `while` loops, and simple input validation.
After running the application, you will see the main menu:

```
Welcome to Contoso Pets Application.

-------------- MAIN MENU --------------
1. Add a new pet.
2. List of all pets.
3. Edit pet information.
4. Delete pet.
Exit
```

Select a menu item by typing its number (e.g., `1` to add a new pet) or type `exit` to close the application.

### ▶ Example Inputs and Outputs

#### Adding a New Pet

```
Select a menu: 1

Pet Species (cat, dog etc.): Dog
Pet Nickname: Max
Pet Age: 3
Pet Physical Condition Description: Large black Labrador retriever.
Pet Personality Description: Very friendly and loves to fetch balls.

```

Output:

```
+ Pet 'Max' added successfully.
```

#### Listing All Pets

```
Select a menu: 2

#ID	  TYPE	 AGE	 NICKNAME	  PHYSICAL CONDITION
1	  dog	 2	     Buddy		  medium sized cream colored.
2	  cat	 4	     Pussi		  little boy.
3	  dog	 3	     Max		  Large black Labrador retriever.
```

#### Editing a Pet

```
Select a menu: 3

Which pet (ID) do you want to update?: 3
Pet Species (dog):
Pet Nickname(Max): Maximus
Pet Age(3): 4
Pet Physical Condition Description(Large black Labrador retriever.): Very energetic dog.
Pet Personality Description(Very friendly and loves to fetch balls.): Loves swimming.
```

If you leave the input blank, the current value will be valid.

#### Deleting a Pet

```
Select a menu: 4

Which pet (ID) do you want to delete?: 2
The pet 2 was deleted.
```

## 📌 Notes

- Typing exit anytime in the menu will terminate the program.
- Input fields cannot be left empty when adding or editing a pet.
- When editing, leaving a field empty keeps the original value.

## Known Missing Features / Future Improvements

- **Input Validation Improvements:**
  - Currently no exception handling if user enters invalid data (e.g., non-numeric age).
- **Search Functionality:**
  - Ability to search pets by name, type, or age.
- **Persistence:**
  - Save pet data to a file or database so it is not lost when the app closes.
- **Refactor into Separate Classes:**
  - Move menu management and pet operations into separate service classes.
- **More Data Fields:**
  - Add fields like adoption status, medical history, etc.
- **Unit Tests:**
  - Add basic unit tests for critical methods.

---

Feel free to fork and enhance this project as you like!
