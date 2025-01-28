from textwrap import dedent

class ListManager:
    def __init__(self):
        self.list = []

    def display_menu(self):
        print(dedent("""
        A menu of options:
        Press 1 to add an element to the end of the list.
        Press 2 to insert an element at a given location.
        Press 3 to delete an element from a given location.
        Press 4 to display all of the list elements.
        Press 5 to count the number of elements in the list.
        Press 6 to clear (initialize) the list.
        Press 7 to exit the program.
        """))

    def run(self):
        is_running = True
        while is_running:
            self.display_menu()
            choice = input("Enter your choice:\n")
            if choice == '1':
                self.add_to_end()
            elif choice == '2':
                self.insert_element()
            elif choice == '3':
                self.delete_element()
            elif choice == '4':
                self.display_elements()
            elif choice == '5':
                self.count_elements()
            elif choice == '6':
                self.clear_list()
            elif choice == '7':
                is_running = False
            else:
                print("Invalid choice. Please try again.")

    # Choice 1
    def add_to_end(self):
        while True:
            item = input("Enter an element to add to the end of the list.\n")
            if item: # Check if the input is not empty
                self.list.append(item) # Add item to the end of the list
                print(f"'{item}' added to the list.")
                print(f"The list is now: {self.list}")
                break
            else:
                print("Invalid input. Please try again.")

    # Choice 2
    def insert_element(self):
        while True:
            try:
                index = int(input("Enter the index where you want to insert the element.\n"))
                value = input("Enter the element to insert.\n")
                self.list.insert(index, value)
                print(f"'{value}' inserted at index {index}.")
                print(f"The list is now: {self.list}")
                break
            except ValueError:
                print("Invalid input. Please enter a valid index.")
            except IndexError:
                print("Invalid index. Please enter a valid index.")

    # Choice 3
    def delete_element(self):
        while True:
            try:
                index = int(input("Enter the index of the element to delete.\n"))
                value = self.list.pop(index)
                print(f"'{value}' deleted from index {index}.")
                print(f"The list is now: {self.list}")
                break
            except ValueError:
                print("Invalid input. Please enter a valid index.")
            except IndexError:
                print("Invalid index. Please enter a valid index.")

    # Choice 4
    def display_elements(self):
        if self.list:
            print(f"The list elements are: {self.list}")
            
        else:
            print("The list is empty.")

    # Choice 5
    def count_elements(self):
        print(f"The number of elements in the list is: {len(self.list)}")

    # Choice 6
    def clear_list(self):
        self.list = []
        print("The list has been cleared.")