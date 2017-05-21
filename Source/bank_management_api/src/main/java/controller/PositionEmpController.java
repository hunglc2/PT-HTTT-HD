package controller;

import java.util.ArrayList;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import model.PositionEmp;
import service.PositionEmpService;

@Controller
@RestController
@RequestMapping("/positionemp")
public class PositionEmpController {
	@Autowired
	PositionEmpService ps;

	@RequestMapping(method = RequestMethod.GET, value = "/all")
	public ArrayList<PositionEmp> getAll() {
		return ps.getAll();
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked" })
	@RequestMapping(value = "/{id}", method = RequestMethod.GET)
	public ResponseEntity getByID(@PathVariable("id") String id) {
		PositionEmp vObject = ps.getByID(Integer.parseInt(id));
		if (vObject == null) {
			return new ResponseEntity("No PositionEmp found for ID " + id, HttpStatus.NOT_FOUND);
		}
		
		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
	@SuppressWarnings({ "unchecked", "rawtypes", "null" })
	@RequestMapping(value = "/update", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<PositionEmp> updateOwner(@RequestBody PositionEmp vObject) {
		vObject = ps.update(vObject);
		if (vObject == null) {
			return new ResponseEntity("No PositionEmp found for ID " + vObject.getIdPosition(), HttpStatus.NOT_FOUND);
		}

		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked" })
	@RequestMapping(value = "/insert", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<PositionEmp> insertOwner(@RequestBody PositionEmp vObject) {
		return new ResponseEntity(ps.insert(vObject), HttpStatus.OK);
	}
	
	@SuppressWarnings({ "rawtypes", "unchecked", "null" })
	@RequestMapping(value = "/delete", method = RequestMethod.POST )
	public @ResponseBody ResponseEntity<PositionEmp> deletetOwner(@RequestBody PositionEmp vObject) {
		vObject = ps.delete(vObject);
		if (vObject == null) {
			return new ResponseEntity("No Owner found for ID " + vObject.getIdPosition(), HttpStatus.NOT_FOUND);
		}
		return new ResponseEntity(vObject, HttpStatus.OK);
	}
	
}
