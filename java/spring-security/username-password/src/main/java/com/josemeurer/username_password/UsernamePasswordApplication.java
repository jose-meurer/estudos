package com.josemeurer.username_password;

import jakarta.servlet.http.HttpServletResponse;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
public class UsernamePasswordApplication implements CommandLineRunner {

	public static void main(String[] args) {
		SpringApplication.run(UsernamePasswordApplication.class, args);
	}

	@Override
	public void run(String... args) throws Exception {
//		PasswordEncoder encoder = new BCryptPasswordEncoder();
//		var password = encoder.encode("123456");
//		System.out.println(password);
	}
}
