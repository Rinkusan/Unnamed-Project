# What do I even want to do? Maybe a simple RPG basis.
# Let's say we are in a Sci-Fi Setting, define some Character Types.
CharTypes = ("Human", "Alien", "Robot","Mortal Hybrid", "Immortal Hybrid", "Android", "Cyborg")
# Character Creation Function
def CharCreation():
    global CharName
    CharName = input("Enter Character Name:")
    global CharType
    CharType = input("What are you? ")
    if CharType in CharTypes: print("Thank you, " + CharName + ", you are now a Level 1 " + CharType + "!"),
    else:
        print("Sorry, that is not a valid thing to be!")
        CharCreation()
CharCreation()
CharLevel = 1
# And our first Character is done.
Character = {
    "CharName": CharName,
    "CharType": CharType,
    "CharLevel": CharLevel,
}
print(Character)