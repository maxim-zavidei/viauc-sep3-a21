package Tier1;

public class UserNotFoundException extends RuntimeException
{
  public UserNotFoundException(String message)
  {
    super(message);
  }
}
