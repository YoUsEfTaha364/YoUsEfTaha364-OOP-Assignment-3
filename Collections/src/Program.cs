using src;




string[] phoneNumbers =
{
    "01012345678",
    "+201512345678",
    "01312345678",
    "0101234567",
    "0101234567a"
};

foreach (string phone in phoneNumbers)
{
    Console.WriteLine(
        $"{phone} => {phone.IsValidEgyptianPhone()}");
}

Console.WriteLine();

string[] nationalIds =
{
    "29901011234567",
    "19901011234567",
    "2990101123456"
};

foreach (string id in nationalIds)
{
    Console.WriteLine(
        $"{id} => {id.IsValidEgyptianNationalId()}");
}



// 01012345678 => True
// +201512345678 => True
// 01312345678 => False
// 0101234567 => False
// 0101234567a => False

// 29901011234567 => True
// 19901011234567 => False
// 2990101123456 => False
