bool a = true && false;

if (a) {
    print("a is true");
} else {
    print("a is false");
};

bool b =  true && !false;

if (b) {
    print("b is true");
} else {
    print("b is false");
};

int num = if (!true) { print("in true"); 1; } else { 2; };
print(num);