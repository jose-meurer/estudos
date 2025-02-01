package com.josemeurer.springSecurity_jwt.controller;

import com.josemeurer.springSecurity_jwt.service.AuthService;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.Authentication;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class AuthController {

    private final AuthService authService;

    public AuthController(AuthService authService) {
        this.authService = authService;
    }

    @PostMapping("/auth")
    public ResponseEntity<String> authenticate(Authentication auth) {
        if (auth == null) return ResponseEntity.badRequest().build();

        String token = authService.authenticate(auth);
        return ResponseEntity.ok(token);
    }
}
