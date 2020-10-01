import io.restassured.RestAssured;
import org.testng.annotations.Test;

public class TestGetExample {

    @Test
    public void getExample(){
        RestAssured.baseURI = "https://reqres.in/api/users";

        RestAssured.given().param("page", "2")
                .when()
                .get()
                .then()
                .assertThat()
                .log()
                .all()
                .statusCode(200);
    }
}