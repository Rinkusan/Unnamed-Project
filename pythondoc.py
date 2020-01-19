# What do I even want to do? Maybe a simple RPG basis.
# Let's say we are in a Sci-Fi Setting, define some Character Types.
CharTypes = ("Human", "Alien", "Robot","Mortal Hybrid", "Immortal Hybrid", "Android", "Cyborg")
# Level 1 
global CharLevel
CharLevel = 1
# Character Creation Function
def CharCreation():
    global CharName
    CharName = input("Enter Character Name:")
    global CharType
    CharType = input("What are you? ")
    if CharType in CharTypes: print("Thank you, " + CharName + ", you are now a Level " + str(CharLevel) + " " + CharType + "!"),
    else:
        print("Sorry, that is not a valid thing to be!")
        CharCreation()
CharCreation()
# And our first Character is done.
Character = {
    "CharName": CharName,
    "CharType": CharType,
    "CharLevel": CharLevel,
}
print(Character)
# Level Up Funcion
CharLevel += 1
# And our first Character is done.
Character = {
    "CharName": CharName,
    "CharType": CharType,
    "CharLevel": CharLevel,
}
print(Character)