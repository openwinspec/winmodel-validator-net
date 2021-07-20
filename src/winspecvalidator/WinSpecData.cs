using System;

namespace winspecvalidator
{
    // Root 
    public class Openwinversion
    {
        public string type { get; set; }
    }

    public class Info
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Customer
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Specification
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Properties2
    {
        public Data data { get; set; }
        public Customer customer { get; set; }
        public Specification specification { get; set; }
        public Openwinversion openwinversion { get; set; }
        public Info info { get; set; }
        public Definitions definitions { get; set; }
        public Dictionaries dictionaries { get; set; }
        public Constructions constructions { get; set; }
        public Id id { get; set; }
        public Locale locale { get; set; }
        public X x { get; set; }
        public Y y { get; set; }
        public Z z { get; set; }
        public Start start { get; set; }
        public End end { get; set; }
        public ArcHeight arcHeight { get; set; }
        public Sides sides { get; set; }
        public Closed closed { get; set; }
        public En en { get; set; }
        public Ru ru { get; set; }
        public De de { get; set; }
        public Sync sync { get; set; }
        public Vendors vendors { get; set; }
        public ProfileSystems profileSystems { get; set; }
        public Profiles profiles { get; set; }
        public Reinforcement reinforcement { get; set; }
        public Spacer spacer { get; set; }
        public Glasses glasses { get; set; }
        public Glazing glazing { get; set; }
        public Panel panel { get; set; }
        public VendorType vendorType { get; set; }
        public Name name { get; set; }
        public Web web { get; set; }
        public VendorId vendorId { get; set; }
        public Article article { get; set; }
        public VendorArticle vendorArticle { get; set; }
        public ProfileType profileType { get; set; }
        public ProfileSystemId profileSystemId { get; set; }
        public A a { get; set; }
        public B b { get; set; }
        public C c { get; set; }
        public D d { get; set; }
        public E e { get; set; }
        public W w { get; set; }
        public W1 w1 { get; set; }
        public W2 w2 { get; set; }
        public H h { get; set; }
        public H1 h1 { get; set; }
        public Ix ix { get; set; }
        public Iy iy { get; set; }
        public Weight weight { get; set; }
        public ColorId colorId { get; set; }
        public ColorName colorName { get; set; }
        public ColorCode colorCode { get; set; }
        public ColorType colorType { get; set; }
        public PanelType panelType { get; set; }
        public Thickness thickness { get; set; }
        public GlassType glassType { get; set; }
        public Lt Lt { get; set; }
        public Sf Sf { get; set; }
        public Lr Lr { get; set; }
        public Ug Ug { get; set; }
        public Size size { get; set; }
        public Material material { get; set; }
        public CommonFeature commonFeature { get; set; }
        public FrameFeature frameFeature { get; set; }
        public SashFeature sashFeature { get; set; }
        public MullionFeature mullionFeature { get; set; }
        public FillingFeature fillingFeature { get; set; }
        public BaseColor baseColor { get; set; }
        public InternalColor internalColor { get; set; }
        public ExternalColor externalColor { get; set; }
        public SillStub sillStub { get; set; }
        public RabbetStub rabbetStub { get; set; }
        public Drained drained { get; set; }
        public CompensationHole compensationHole { get; set; }
        public OpeningType openingType { get; set; }
        public CalcWind calcWind { get; set; }
        public GlazingId glazingId { get; set; }
        public PanelId panelId { get; set; }
        public GlazingFeature glazingFeature { get; set; }
        public PanelFeature panelFeature { get; set; }
        public VirtualFeature virtualFeature { get; set; }
        public FillingType fillingType { get; set; }
        public Features features { get; set; }
        public GlazingBeads glazingBeads { get; set; }
        public StartExt start_ext { get; set; }
        public StartInt start_int { get; set; }
        public EndExt end_ext { get; set; }
        public EndInt end_int { get; set; }
        public ProfileId profileId { get; set; }
        public Cuttings cuttings { get; set; }
        public Drain drain { get; set; }
        public ComponentType componentType { get; set; }
        public GeometryId geometryId { get; set; }
        public SplitterId splitterId { get; set; }
        public Beams beams { get; set; }
        public Components components { get; set; }
        public ElementType elementType { get; set; }
        public Geometry geometry { get; set; }
        public Splitters splitters { get; set; }
        public Cutting cutting { get; set; }
        public RoughOpening roughOpening { get; set; }
        public Elements elements { get; set; }
        public Connections connections { get; set; }
    }

    public class Definitions
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public Info Info { get; set; }
        public Point Point { get; set; }
        public Segment Segment { get; set; }
        public Polygon Polygon { get; set; }
        public Locale Locale { get; set; }
        public LocaleString LocaleString { get; set; }
        public Dictionaries Dictionaries { get; set; }
        public VendorType VendorType { get; set; }
        public Vendor Vendor { get; set; }
        public VendorMaterial VendorMaterial { get; set; }
        public ProfileType ProfileType { get; set; }
        public ProfileSystem ProfileSystem { get; set; }
        public Profile Profile { get; set; }
        public Reinforcement Reinforcement { get; set; }
        public ColorType ColorType { get; set; }
        public Color Color { get; set; }
        public Panel Panel { get; set; }
        public GlassType GlassType { get; set; }
        public Glass Glass { get; set; }
        public Glazing Glazing { get; set; }
        public SpacerMaterial SpacerMaterial { get; set; }
        public Spacer Spacer { get; set; }
        public HardwareType HardwareType { get; set; }
        public HardwareSystem HardwareSystem { get; set; }
        public ProductType ProductType { get; set; }
        public ComponentType ComponentType { get; set; }
        public ComponentFeatures ComponentFeatures { get; set; }
        public CommonFeature CommonFeature { get; set; }
        public FrameFeature FrameFeature { get; set; }
        public SashOpeningType SashOpeningType { get; set; }
        public SashFeature SashFeature { get; set; }
        public MullionFeature MullionFeature { get; set; }
        public FillingType FillingType { get; set; }
        public GlazingFeature GlazingFeature { get; set; }
        public PanelFeature PanelFeature { get; set; }
        public VirtualFeature VirtualFeature { get; set; }
        public FillingTypeFeatures FillingTypeFeatures { get; set; }
        public FillingFeature FillingFeature { get; set; }
        public GlazingBeadFeature GlazingBeadFeature { get; set; }
        public CuttingType CuttingType { get; set; }
        public BeamCuttings BeamCuttings { get; set; }
        public Beam Beam { get; set; }
        public Component Component { get; set; }
        public Element Element { get; set; }
        public Connection Connection { get; set; }
        public Construction Construction { get; set; }
    }

    public class Dictionaries
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Items
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Constructions
    {
        public string type { get; set; }
        public string description { get; set; }
        public Items items { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Locale
    {
        public string type { get; set; }
    }

    public class Info2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class X
    {
        public string type { get; set; }
    }

    public class Y
    {
        public string type { get; set; }
    }

    public class Z
    {
        public string type { get; set; }
    }

    public class Point
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class Start
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class End
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class ArcHeight
    {
        public string type { get; set; }
    }

    public class Segment
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class Sides
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Closed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Polygon
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class Locale2
    {
        public string description { get; set; }
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class En
    {
        public string type { get; set; }
    }

    public class Ru
    {
        public string type { get; set; }
    }

    public class De
    {
        public string type { get; set; }
    }

    public class AnyOf
    {
        public List<string> required { get; set; }
    }

    public class LocaleString
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<AnyOf> anyOf { get; set; }
    }

    public class Sync
    {
        public string type { get; set; }
    }

    public class Vendors
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class ProfileSystems
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Profiles
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Reinforcement
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Spacer
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Glasses
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Glazing
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Panel
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Dictionaries2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class VendorType
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class VendorType2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Name
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
        public string type { get; set; }
        public string typw { get; set; }
    }

    public class Web
    {
        public string type { get; set; }
    }

    public class Vendor
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class VendorId
    {
        public string type { get; set; }
    }

    public class Article
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class VendorMaterial
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class ProfileType
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> @enum { get; set; }
    }

    public class ProfileSystem
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class VendorArticle
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class ProfileType2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class ProfileSystemId
    {
        public string type { get; set; }
    }

    public class A
    {
        public string type { get; set; }
    }

    public class B
    {
        public string type { get; set; }
    }

    public class C
    {
        public string type { get; set; }
    }

    public class D
    {
        public string type { get; set; }
    }

    public class E
    {
        public string type { get; set; }
    }

    public class W
    {
        public string type { get; set; }
    }

    public class W1
    {
        public string type { get; set; }
    }

    public class W2
    {
        public string type { get; set; }
    }

    public class H
    {
        public string type { get; set; }
    }

    public class H1
    {
        public string type { get; set; }
    }

    public class Profile
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class Ix
    {
        public string type { get; set; }
    }

    public class Iy
    {
        public string type { get; set; }
    }

    public class Weight
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Reinforcement2
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class ColorType
    {
        public string description { get; set; }
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class ColorId
    {
        public string type { get; set; }
    }

    public class ColorName
    {
        public string type { get; set; }
    }

    public class ColorCode
    {
        public string type { get; set; }
    }

    public class ColorType2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Color
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class PanelType
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Thickness
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Panel2
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class GlassType
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> @enum { get; set; }
    }

    public class GlassType2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Lt
    {
        public string type { get; set; }
    }

    public class Sf
    {
        public string type { get; set; }
    }

    public class Lr
    {
        public string type { get; set; }
    }

    public class Ug
    {
        public string type { get; set; }
    }

    public class Glass
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class Glazing2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class SpacerMaterial
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> @enum { get; set; }
    }

    public class Size
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Material
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Spacer3
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class HardwareType
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class HardwareSystem
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class ProductType
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> @enum { get; set; }
    }

    public class ComponentType
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class CommonFeature
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class FrameFeature
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class SashFeature
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class MullionFeature
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class FillingFeature
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class OneOf
    {
        public List<string> required { get; set; }
    }

    public class ComponentFeatures
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<OneOf> oneOf { get; set; }
    }

    public class BaseColor
    {
        public string type { get; set; }
        public string description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class InternalColor
    {
        public string type { get; set; }
        public string description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class ExternalColor
    {
        public string type { get; set; }
        public string description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class CommonFeature2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class SillStub
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class RabbetStub
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Drained
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class CompensationHole
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class FrameFeature2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> requred { get; set; }
    }

    public class SashOpeningType
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class OpeningType
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class SashFeature2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> requred { get; set; }
    }

    public class CalcWind
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class MullionFeature2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class FillingType
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class GlazingId
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class GlazingFeature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class PanelId
    {
        public string description { get; set; }
    }

    public class PanelFeature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class VirtualFeature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class GlazingFeature2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class PanelFeature2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class VirtualFeature2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class FillingTypeFeatures
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<OneOf> oneOf { get; set; }
    }

    public class FillingType2
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Features
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class GlazingBeads
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class FillingFeature2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class GlazingBeadFeature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class CuttingType
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
    }

    public class StartExt
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class StartInt
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class EndExt
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class EndInt
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class BeamCuttings
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class ProfileId
    {
        public string type { get; set; }
        public string description { get; set; }
    }

    public class Cuttings
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Drain
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
        public string description { get; set; }
    }

    public class Beam
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class ComponentType2
    {
        public string description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class GeometryId
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class SplitterId
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Beams
    {
        public string type { get; set; }
        public string description { get; set; }
        public Items items { get; set; }
    }

    public class Components
    {
        public string type { get; set; }
        public string description { get; set; }
        public Items items { get; set; }
    }

    public class Component
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class ElementType
    {
        public string description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public Items items { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Splitters
    {
        public string type { get; set; }
        public string description { get; set; }
        public Items items { get; set; }
    }

    public class Element
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class Cutting
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Connection
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
    }

    public class RoughOpening
    {
        public string description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public class Elements
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Connections
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Construction
    {
        public string type { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
    }

    public class Root
    {
        [JsonProperty("$schema")]
        public string Schema { get; set; }

        [JsonProperty("$id")]
        public string Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<string> required { get; set; }
        public Definitions definitions { get; set; }
    }

}
