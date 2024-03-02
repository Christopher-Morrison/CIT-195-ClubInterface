using System;
namespace ClubInterface
{
    interface IClub
    {
        // Properties
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        // methods
        public string FullName();
    }
    class ClubInterface
    {
        class GolfMembership : IClub
        {
            // interfact properties
            public int Id {get; set;}
            public string FirstName {get; set;}
            public string LastName {get; set;}
            // This class properties
            public int Age {get; set;}
            public bool IsMember {get;set;}
            public int MemberDuration {get; set;} // in years

            public GolfMembership()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Age = 0;
                IsMember = false;
                MemberDuration = 0;
            }
            public GolfMembership(int id, string firstName, string lastName, int age, bool isMember, int memberDuration)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                IsMember = isMember;
                MemberDuration = memberDuration;
            }
            public string FullName()
            {
                return "Firstname: " + FirstName + "\nLastName: " + LastName;
            }
            public string DisplayFields()
            {
                return "ID: " + Id + "\nFirstname: " + FirstName + "\nLastName: " + LastName + "\nAge: " + Age + "\nIsMember: " + IsMember + "\nMembership Duration: " + MemberDuration;
            }
        }
        static void Main(string[] args)
        {
            GolfMembership firstMember = new GolfMembership();
            firstMember.FirstName = "duncan";
            firstMember.LastName = "Morrison";
            firstMember.Age = 69;
            firstMember.IsMember = true;
            firstMember.MemberDuration = 15;
            
            Console.WriteLine("How many entries would you like to make?");
            int newEntries = int.Parse(Console.ReadLine());

            GolfMembership [] golfDatabase = new GolfMembership[newEntries];
            for ( int i = 0; i < newEntries; i++ )
            {
                Console.WriteLine("Member id: ");
                int mId = int.Parse(Console.ReadLine());
                Console.WriteLine("First Name: ");
                string mFirstName = Console.ReadLine();
                Console.WriteLine("Last Name: ");
                string mLastName = Console.ReadLine();
                Console.WriteLine("Age: ");
                int mAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Currently a member? true or false: ");
                bool mIsMember = false;
                if (Console.ReadLine() == "true")   
                    { mIsMember = true; }
                Console.WriteLine("Length of membership in years: ");
                int mMembershipDuration = int.Parse(Console.ReadLine());
                
                GolfMembership member = new GolfMembership(mId, mFirstName, mLastName, mAge, mIsMember, mMembershipDuration);
                golfDatabase[i] = member;
            }
            Console.WriteLine(firstMember.DisplayFields());
            for ( int i = 0;i < newEntries; i++ ) { Console.WriteLine(golfDatabase[i].DisplayFields()); }
        }
    }
}