class User
{
    //UC-1 Implementation for setting the attributes fields
    private string firstName;
    private string lastName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string email;
    private int phoneNum;
    //Encapsulation for data security
    public string FirstName
    {
        get => firstName; set => firstName = value;
    }
    public string LastName
    {
        get => lastName; set => lastName = value;
    }
    public string Address
    {
        get => address; set => address = value;
    }
    public string City
    {
        get => city; set => city = value;
    }
    public string State
    {
        get => state; set => state = value;
    }
    public string Zip
    {
        get => zip; set => zip = value;
    }
    public string Email
    {
        get => email; set => email = value;
    }
    public int PhoneNum
    {
        get => phoneNum; set => phoneNum = value;
    }
    // UC-7: Override Equals
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is User))
        {
            return false;
        }

        User other = (User)obj;
        return this.FirstName == other.FirstName && this.LastName == other.LastName;
    }
    public override string ToString()
    {
        return FirstName + " " + LastName + ", " + City + ", " + State + ", " + PhoneNumber;
    }

}