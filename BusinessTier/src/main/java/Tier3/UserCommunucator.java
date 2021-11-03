package Tier3;

import java.util.ArrayList;
import java.util.Arrays;

import Shared.User;
import org.springframework.http.ResponseEntity;
import org.springframework.web.client.RestTemplate;

public class UserCommunucator {
    public UserCommunucator() {

    }

    public ArrayList<User> getUsersFromDatabase(RestTemplate restTemplate, String url) {
        try {

            ResponseEntity<User[]> responseEntity = restTemplate.getForEntity(url + "User/GetUsers", User[].class);
            User[] users = responseEntity.getBody();
            /*
             * MediaType contentType = responseEntity.getHeaders().getContentType();
             * HttpStatus statusCode = responseEntity.getStatusCode();
             */
            return new ArrayList<>(Arrays.asList(users));
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
}