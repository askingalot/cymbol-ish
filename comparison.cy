fun comp(a, b) {
    print(a);
    print(b);
    if (a == b) {
        print("equal");
    };
    if (a != b) {
        print("not equal");
    };
    if (a > b) {
        print("greater");
    };
    if (a >= b) {
        print("greater or equal");
    };
    if (a < b) {
        print("lesser");
    };
    if (a <= b) {
        print("lesser or equal");
    };
};

comp(0, 1);
comp(1, 0);
comp(20, 20);

comp("a", "b");
comp("b", "a");
comp("a", "a");

comp(true, false);
comp(false, true);
comp(false, false);

comp("a", true);