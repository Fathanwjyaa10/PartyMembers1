// Mengisi 4 nama anggota party (bebas sesuai keinginan)
string[] party = { "Warrior", "Mage", "Archer", "Healer" };

// Display all party members using a for loop
for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"Member {i}: {party[i]}");
}

// Change the third party member (index 2)
party[2] = "Rogue";

Console.WriteLine($"\nUpdated Member 2: {party[2]}");