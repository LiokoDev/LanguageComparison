# Read File Application

try:
    # Read all lines in the test file to a list.
    with open("testfile.txt") as file:
        lines = file.readlines()

    # Print all lines in the list.
    for line in lines:
        print('Read Line: ' + line.strip())
except OSError as e:
    # Report error to user.
    print("Error reading testfile\n")
    print(e)
