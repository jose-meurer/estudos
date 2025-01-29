package com.josemeurer.autoconfiguration.controller;

import com.josemeurer.autoconfiguration.dto.HelloDTO;
import org.springframework.http.ResponseEntity;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/hello")
public class HelloController {

    @GetMapping
    public ResponseEntity<HelloDTO> hello() {
        return ResponseEntity.ok(new HelloDTO("Hello World"));
    }
}
