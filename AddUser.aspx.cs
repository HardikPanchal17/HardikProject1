public int AddUserdata(Users user)
{
  UserRepo obj=new UserRepo();
  obj.save(user);
  
}
