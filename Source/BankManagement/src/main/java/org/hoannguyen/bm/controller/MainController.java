package org.hoannguyen.bm.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class MainController {
	
	@RequestMapping("/")
    public String index(Model model) {
        model.addAttribute("title", "Login page");
        return "index";
    }
	
	@RequestMapping("/login")
    public String login(Model model) {
        model.addAttribute("title", "Login page");
        model.addAttribute("title", "Login page");
        return "login";
    }
	
	@RequestMapping("/customer")
    public String customer(Model model) {
        model.addAttribute("title", "CRM Model HoanNguyen | Starter");
        return "customer";
    }
}
