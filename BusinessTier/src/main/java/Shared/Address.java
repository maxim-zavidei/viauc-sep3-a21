package Shared;

import java.io.Serializable;

import javax.persistence.Entity;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;

@JsonIgnoreProperties(ignoreUnknown = true)
@Entity
public class Address implements Serializable
{
  @JsonProperty("id")
  private int id;
  @JsonProperty("streetName")
  private String streetName;
  
  @JsonProperty("number")
  private String number;
  
  @JsonProperty("city")
  private String city;
  
  @JsonProperty("country")
  private String country;
  public void setCity(String city) {
      this.city = city;
  }
  public void setCountry(String country) {
      this.country = country;
  }
  public void setId(int id) {
      this.id = id;
  }
  public void setNumber(String number) {
      this.number = number;
  }public void setStreetName(String streetName) {
      this.streetName = streetName;
  }
}
