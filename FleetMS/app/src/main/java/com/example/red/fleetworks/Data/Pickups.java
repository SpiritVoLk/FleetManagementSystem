package com.example.red.fleetworks.Data;

import java.io.Serializable;

public class Pickups implements Serializable {
    int carrierId;
    int driverId;
    int shipmentOrderId;
    String time;
    String streetname;
    String city;
    String province;
    String zipcode;

    public Pickups(int carrierId, int driverId, int shipmentOrderId, String time, String streetname, String city, String province, String zipcode) {
        this.carrierId = carrierId;
        this.driverId = driverId;
        this.shipmentOrderId = shipmentOrderId;
        this.time = time;
        this.streetname = streetname;
        this.city = city;
        this.province = province;
        this.zipcode = zipcode;
    }

    public String getTime() {
        return time.replace("T", " ");
    }

    public String getStreetname() {
        return streetname;
    }

    public String getCity() {
        return city;
    }

    public String getProvince() {
        return province;
    }

    public String getZipcode() {
        return zipcode;
    }
}
