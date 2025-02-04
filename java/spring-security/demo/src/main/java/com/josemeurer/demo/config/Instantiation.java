package com.josemeurer.demo.config;

import com.josemeurer.demo.entity.Role;
import com.josemeurer.demo.entity.User;
import com.josemeurer.demo.repository.RoleRepository;
import com.josemeurer.demo.repository.UserRepository;
import org.springframework.boot.ApplicationRunner;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.crypto.password.PasswordEncoder;

import java.util.List;

@Configuration
public class Instantiation {

    @Bean
    public ApplicationRunner runner(UserRepository userRepository, RoleRepository roleRepository, PasswordEncoder passwordEncoder) {
        return args -> {

            Role roleUser = new Role();
            roleUser.setName("ROLE_USER");

            Role roleAdmin = new Role();
            roleAdmin.setName("ROLE_ADMIN");

            roleRepository.saveAll(List.of(roleUser, roleAdmin));

            String password = passwordEncoder.encode("password");

            User user = new User();
            user.setUsername("user");
            user.setPassword(password);
            user.setRole(roleUser);

            User admin = new User();
            admin.setUsername("admin");
            admin.setPassword(password);
            admin.setRole(roleAdmin);

            userRepository.saveAll(List.of(user, admin));
        };
    }
}
