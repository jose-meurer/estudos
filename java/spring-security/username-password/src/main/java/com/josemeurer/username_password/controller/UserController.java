package com.josemeurer.username_password.controller;

import com.josemeurer.username_password.service.UserService;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.core.Authentication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/users")
public class UserController {

    private final UserService userService;

    public UserController(UserService userService) {
        this.userService = userService;
    }

    @GetMapping
    public ResponseEntity<String> getUserInfo(Authentication auth) {
        String username = "Usuário autenticado: " + auth.getName();
        return ResponseEntity.ok().body(username);
    }
}
