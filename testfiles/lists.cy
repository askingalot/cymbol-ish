list a = [1, 2, 3];
list b = [];

int c = 2;
bool t = true;
string hi = "hi";

print(a);
print(b);

print("42");
print();

list strs = ["blah", "bleh"];
print(strs);

print([true, false, true]);

print(a[0]);

print(strs[1]);


list listoflist = [
    [1, 2, 3],
    [4, 5, 6],
    ["a", "b", "c"] // boo
];
print(listoflist);

list one = listoflist[0];
print(one);

list three = listoflist[2];
print(three);

print(len(three));

//print(strs[1000]);
list bad = [true, false, "false", 2];


fun iterate(lst, index) {
    if (index < len(lst)) {
        print(lst[index]);
        iterate(lst, index+1);
    };
};
list aList = ["this", "is", "a", "list", "of", "strings"];
iterate(aList, 0);


list nums = range(10);
print(nums); 

iterate(range(10), 0);

int strlen = len("four");
print(strlen);

//print(len(7));

list nums1 = [1, 2, 3];
list nums2 = [4, 5, 6];
list nums3 = concat(nums1, nums2);
print(nums3);

string hello = "hello ";
string world = "world!";
print(concat(hello, world));