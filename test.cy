// This is not really the Cymbol language, but it is loosely inspired by it.
// It's also not at all complete. It's just a place to practice some language building.

int a = 2;
/*
print(a * a / a);
print(4 * 4 + a);
print(2 + 2 * 20);
print(4 / 2);
*/

int num = 100;
//int num = false;

bool isTrue = true;
//bool fail = 22;

print(isTrue);

if (isTrue) {
    print("It's True");
};

fun timesFour(num) {
    int four = 4;
    print(num);
    num * four;
};

fun add(num1, num2) {
    num1 + num2;
};

fun printHelloWorld() {
    print("hello world");
};

printHelloWorld();

print(add(1, 2));

print("Call the timesFour() Function with 2");
print(timesFour(2));

print();

print("Call the timesFour() Function with 200");
print(timesFour(200));

print(num);